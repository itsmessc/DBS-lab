using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        OracleConnection conn; 
        OracleCommand comm; 
        OracleDataAdapter da; 
        DataSet ds;
        DataTable dt; 
        DataRow dr; 
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "DATA SOURCE=172.16.54.24:1521/ictorcl;USER ID=IT638;Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
            MessageBox.Show("Connected");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "UPDATE PARTICIPATED SET DAMAGE_AMOUNT = :damageAmount WHERE REPORT_NUMBER = :reportNumber AND REGNO = :regNo";
            cm.Parameters.Add(":damageAmount", OracleDbType.Int32).Value = 25000;
            cm.Parameters.Add(":reportNumber", OracleDbType.Int32).Value = 12;
            cm.Parameters.Add(":regNo", OracleDbType.Varchar2).Value = "KA19 S1452";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Updated");
            conn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "DELETE FROM PARTICIPATED WHERE report_number IN (SELECT report_number FROM ACCIDENT WHERE EXTRACT(YEAR FROM acc_date) =:year)";
            cm.Parameters.Add(":year", OracleDbType.Int32).Value = 2018;
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            cm.CommandText = " DELETE FROM ACCIDENT WHERE EXTRACT(YEAR FROM acc_date)=2018";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "ALTER TABLE OWNS ADD (PRICE INT)";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Added column");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "ALTER TABLE OWNS DROP COLUMN PRICE";
            cm.CommandType = CommandType.Text;

            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Column 'PRICE' deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting column: " + ex.Message);
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "SELECT COUNT(DISTINCT DRIVERID) FROM PARTICIPATED WHERE REPORT_NUMBER IN (SELECT REPORT_NUMBER FROM ACCIDENT WHERE EXTRACT(YEAR FROM ACC_DATE) = :year)";
            cm.Parameters.Add(":year", OracleDbType.Int32).Value = 2019;
            cm.CommandType = CommandType.Text;

            try
            {
                OracleDataReader reader = cm.ExecuteReader();
                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    MessageBox.Show("Driver IDs in 2019: " + count);
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message);
            }

            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "SELECT COUNT(PARTICIPATED.REGNO) FROM PARTICIPATED, CAR WHERE PARTICIPATED.REGNO=CAR.REGNO AND CAR.MODEL=:model";
            cm.Parameters.Add(":model", OracleDbType.Varchar2).Value = "Hyundai Creta";
            cm.CommandType = CommandType.Text;
            try
            {
                OracleDataReader reader = cm.ExecuteReader();
                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    MessageBox.Show("Accidents by Car Hyundai Creta: " + count);
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message);
            }

            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "SELECT NAME AS OWNER_NAME, COUNT(REPORT_NUMBER) AS NO_OF_ACCIDENT FROM PARTICIPATED, PERSON WHERE PERSON.DRIVERID = PARTICIPATED.DRIVERID GROUP BY NAME ORDER BY COUNT(REPORT_NUMBER) DESC";
            cm.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new OracleDataAdapter(cm);

            try
            {
                da.Fill(ds, "Tbl_participated");
                dataGridView1.DataSource = ds.Tables["Tbl_participated"];
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }

            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "SELECT PERSON.NAME FROM PERSON MINUS (SELECT DISTINCT PERSON.NAME FROM PERSON,PARTICIPATED WHERE PERSON.DRIVERID = PARTICIPATED.DRIVERID)";
            cm.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new OracleDataAdapter(cm);

            try
            {
                da.Fill(ds, "Tbl_person");
                dataGridView1.DataSource = ds.Tables["Tbl_person"];
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show("Error: " + ex.Message);
            }

            conn.Close();
        }

       
    }
}
