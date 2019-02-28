using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// My includes
using System.IO;
using System.Data.SQLite;

namespace productivity_tracker
{
    public partial class FormProductivityTracker : Form
    {
        SQLiteConnection m_dbConnection;
        bool durationWarning = false;
        bool typeWarning = false;
        bool descriptionWarning = false;

        public FormProductivityTracker()
        {
            InitializeComponent();

            bool createDb = false;
            if (!File.Exists("productivity-tracker.db"))
            {
                createDb = true;
                SQLiteConnection.CreateFile("productivity-tracker.db");
            }

            m_dbConnection = new SQLiteConnection("Data Source=productivity-tracker.db;Version=3;");
            m_dbConnection.Open();

            SQLiteCommand command;

            if (createDb)
            { 
                string createTable = "CREATE TABLE IF NOT EXISTS [productivity_tracker] ("
                    + "[id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,"
                    + "[start_time] TEXT NOT NULL,"
                    + "[duration] TEXT NOT NULL,"
                    + "[type] TEXT NOT NULL,"
                    + "[description] TEXT NOT NULL)";
                command = new SQLiteCommand(createTable, m_dbConnection);
                command.ExecuteNonQuery();
            }

            // Data Entry Tab
            dataGridFill();
            dateTimePickerStartTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartTime.CustomFormat = "yyyy-MM-dd HH:mm";

            dateTimePickerDuration.Format = DateTimePickerFormat.Custom;
            dateTimePickerDuration.CustomFormat = "HH:mm";
            dateTimePickerDuration.ShowUpDown = true;
            dateTimePickerDuration.Value = Convert.ToDateTime("00:00");

            // Set alpha to 0, so radio buttons and panel don't combine to be darker
            radioButtonWork.BackColor = Color.FromArgb(0, default(Color));
            radioButtonPersonal.BackColor = Color.FromArgb(0, default(Color));
            radioButtonLeisure.BackColor = Color.FromArgb(0, default(Color));

            // Analysis Tab
            radioButton7Days.Checked = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Don't allow duration, type, or description to be empty
            string duration = Program.ToString(dateTimePickerDuration.Value);
            if (duration == "00:00")
            {
                dateTimePickerDuration.Focus();
                panelDuration.BackColor = Color.FromArgb(175, Color.Red);
                durationWarning = true;
            }
            else if (durationWarning)
            {
                panelDuration.BackColor = default(Color);
                durationWarning = false;
            }

            if (!radioButtonWork.Checked && !radioButtonPersonal.Checked && !radioButtonLeisure.Checked)
            {
                panelType.BackColor = Color.FromArgb(175, Color.Red);
                typeWarning = true;
            }
            else if (typeWarning)
            {
                panelType.BackColor = default(Color);
                typeWarning = false;
            }

            if (textBoxDesc.Text == "")
            {
                textBoxDesc.Focus();
                panelDescription.BackColor = Color.FromArgb(175, Color.Red);
                descriptionWarning = true;
            }
            else if (descriptionWarning)
            {
                panelDescription.BackColor = default(Color);
                descriptionWarning = false;
            }

            if (!durationWarning && !typeWarning && !descriptionWarning)
            {
                RadioButton rb;
                if (radioButtonWork.Checked)
                {
                    rb = radioButtonWork;
                }
                else if (radioButtonPersonal.Checked)
                {
                    rb = radioButtonPersonal;
                }
                else
                {
                    rb = radioButtonLeisure;
                }
                DateTime startTime = dateTimePickerStartTime.Value;

                // TODO - ALW: Escape single quotes
                // Example: [productivity-tracker] Don't allow rows with blanks
                string sql = "INSERT INTO productivity_tracker (start_time, duration, type, description) values ('{0}', '{1}', '{2}', '{3}')";
                sql = String.Format(sql, startTime.ToString("yyyy-MM-dd HH:mm"), Program.ToString(dateTimePickerDuration.Value), rb.Text, textBoxDesc.Text);
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                // Update data grid view with last 10 entries
                sql = "select * from productivity_tracker order by id DESC limit 10";
                command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);

                // Reset values
                dateTimePickerDuration.Value = Convert.ToDateTime("00:00");
                radioButtonWork.Checked = false;
                radioButtonPersonal.Checked = false;
                radioButtonLeisure.Checked = false;
                textBoxDesc.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string sql = "delete from productivity_tracker where id = {0}";
                sql = String.Format(sql, row.Cells[0].Value);
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                textBoxDesc.Text = "";

                dataGridView1.Rows.RemoveAt(row.Index);
            }

            dataGridFill();
        }

        private void FormProductivityTracker_Load_1(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 92;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 49;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int historyInDays = 0;
            if (radioButton7Days.Checked)
            {
                historyInDays = 7;
            }
            else if (radioButton30Days.Checked)
            {
                historyInDays = 30;
            }
            else if (radioButton90Days.Checked)
            {
                historyInDays = 90;
            }
            else if (radioButton1Year.Checked)
            {
                historyInDays = 365;
            }

            string str = "SELECT SUM(strftime('%s', duration) - strftime('%s', '00:00')) FROM productivity_tracker WHERE type = '{0}' AND start_time >= DATETIME('now', '-{1} day')";
            string sql = String.Format(str, "Work", historyInDays);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            int workSeconds = command.ExecuteScalar() == System.DBNull.Value ? 0 : Convert.ToInt32(command.ExecuteScalar());
            TimeSpan workTime = TimeSpan.FromSeconds(workSeconds);

            sql = String.Format(str, "Personal", historyInDays);
            command = new SQLiteCommand(sql, m_dbConnection);
            int personalSeconds = command.ExecuteScalar() == System.DBNull.Value ? 0 : Convert.ToInt32(command.ExecuteScalar());
            TimeSpan personalTime = TimeSpan.FromSeconds(personalSeconds);

            sql = String.Format(str, "Leisure", historyInDays);
            command = new SQLiteCommand(sql, m_dbConnection);
            int leisureSeconds = command.ExecuteScalar() == System.DBNull.Value ? 0 : Convert.ToInt32(command.ExecuteScalar());
            TimeSpan leisureTime = TimeSpan.FromSeconds(leisureSeconds);

            textBoxWorkTime.Text = Program.ToString(workTime);
            textBoxPersonalTime.Text = Program.ToString(personalTime);
            textBoxLeisureTime.Text = Program.ToString(leisureTime);

            double totalTime = workTime.TotalSeconds + personalTime.TotalSeconds + leisureTime.TotalSeconds;
            int workPercent = totalTime == 0 ? 0 : Convert.ToInt32(workTime.TotalSeconds / totalTime * 100);
            int personalPercent = totalTime == 0 ? 0 : Convert.ToInt32(personalTime.TotalSeconds / totalTime * 100);
            int leisurePercent = totalTime == 0 ? 0 : Convert.ToInt32(leisureTime.TotalSeconds / totalTime * 100);

            textBoxWorkPercent.Text = workPercent.ToString();
            textBoxPersonalPercent.Text = personalPercent.ToString();
            textBoxLeisurePercent.Text = leisurePercent.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Save edit to database
            int cellColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            if (Enumerable.Range(1, 4).Contains(cellColumnIndex))
            {
                string sql = "UPDATE productivity_tracker SET {0} = '{1}' WHERE id = {2}";
                string[] tableColumns = { "start_time", "duration", "type", "description" };
                string cellValue = dataGridView1.CurrentRow.Cells[cellColumnIndex].Value.ToString();
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = String.Format(sql, tableColumns[cellColumnIndex - 1], cellValue, id);
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
        }

        private void dataGridFill()
        {
            // Fill data grid view with last 10 entries
            string sql = "select * from productivity_tracker order by id DESC limit 10";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = new BindingSource(table, null);
        }
    }
}
