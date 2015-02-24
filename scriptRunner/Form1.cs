using scriptRunner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scriptRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();


            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderDialog.SelectedPath = @"C:\scripts";
            var result = folderDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(folderDialog.SelectedPath))
                {
                    ProcessDirectory(folderDialog.SelectedPath);
                }

            }
        }

        private void ProcessDirectory(string path)
        {
            string[] fileEntries = Directory.GetFiles(path);
           
            
            foreach (string file in fileEntries)
            {
                chkScripts.Items.Add(file, true);
            }
        }

        private void ProcessFile(string fileName)
        {
            string sql = File.ReadAllText(fileName);

            //var connstring = Settings.Default.conn0;
            var connstring = ((ComboboxItem)cbConnections.SelectedItem).Value.ToString();


            var conn = new SqlConnection(connstring);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                lblScripts.Text += sql + Environment.NewLine + "Rows affected : " + result + Environment.NewLine;
            }
            conn.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connections = Settings.Default.Properties;
            var lstConn = new List<ComboboxItem>();
            for (int i = 0; i < connections.Count + 1; i++)
            {
                var cbItem = new ComboboxItem();
                switch (i)
                {
                    case (int)ConnectionStrings.DB1:
                        cbItem.Value = Settings.Default.Properties["conn" + i.ToString()].DefaultValue.ToString();
                        cbItem.Text = ConnectionStrings.DB1.ToString();
                        break;
                    case (int)ConnectionStrings.DB2:
                        cbItem.Value = Settings.Default.Properties["conn" + i.ToString()].DefaultValue.ToString();
                        cbItem.Text = ConnectionStrings.DB2.ToString();
                        break;

                }
                if (cbItem.Value != null)
                    cbConnections.Items.Add(cbItem);
            }

        }



        private void btnRunScripts_Click(object sender, EventArgs e)
        {
            foreach (var item in chkScripts.CheckedItems)
            {
                ProcessFile(item.ToString());
            }
            MessageBox.Show("Completed");
        }

        private void cbConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConnections.SelectedItem != null)
                btnGetScripts.Enabled = true;
        }

        public enum ConnectionStrings
        {
            DB1 = 0,
            DB2 = 1
        }


        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


    }
}
