using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmmoLog
{
    public partial class Form1 : Form
    {
        static string ConnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Users\\nelis\\source\\repos\\AmmoLog\\AmmoLogDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con   = new SqlConnection(ConnString);
        string selectedFACaliber,selectedFA,selectedAmmo;
        public Form1()
        {
            InitializeComponent();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Firearms", ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Firearms");
            dataGridView1.DataSource = ds.Tables["Firearms"].DefaultView;
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Sessions", ConnString);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "Sessions");
            dataGridView1.DataSource = ds1.Tables["Sessions"].DefaultView;

            LoadCaliberList();
            LoadAmmoList();
            LoadFAList();

            SqlDataAdapter dafa = new SqlDataAdapter("SELECT * FROM Firearms", ConnString);
            DataSet dsfa = new DataSet();
            dafa.Fill(dsfa, "Firearms");
            dataGridView1.DataSource = dsfa.Tables["Firearms"].DefaultView;
        }

        private void btnAddFA_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Firearms(Brand,Model,Serial,Caliber) Values('" + tbFABrand.Text + "','" + tbFAModel.Text + "','" + tbFASerial.Text + "','" + cmbFACaliber.SelectedValue + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            LoadFAList();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Firearms", ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Firearms");
            dataGridView1.DataSource = ds.Tables["Firearms"].DefaultView;
        }

        private void btnAddCaliber_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Calibers(Caliber) Values('" + tbCal.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            LoadCaliberList();
        }

        private void btnAddAmmo_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ammo(Brand,Caliber,Weight,Style) Values('" + tbAmmoBrand.Text + "','" + cmbAmmoCaliber.Text + "','" + Convert.ToInt32(numAmmoWeight.Value) + "','" + cmbAmmoStyle.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            LoadAmmoList();
        }

        private void LoadCaliberList()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    string query = "SELECT * from Calibers";
                    SqlDataAdapter dacb = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet dscb = new DataSet();
                    dacb.Fill(dscb, "Calibers");
                    cmbFACaliber.DisplayMember = "Caliber";
                    cmbFACaliber.ValueMember = "CalId";
                    cmbFACaliber.DataSource = dscb.Tables["Calibers"];
                    cmbAmmoCaliber.DisplayMember = "Caliber";
                    cmbAmmoCaliber.ValueMember = "CalId";
                    cmbAmmoCaliber.DataSource = dscb.Tables["Calibers"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }

        private void LoadFAList()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    string query = "SELECT Brand+' '+Model+' '+Serial AS FA from Firearms";
                    SqlDataAdapter dafa = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet dsfa = new DataSet();
                    dafa.Fill(dsfa, "Firearms");
                    cmbSessionFA.DisplayMember = "FA";
                    cmbSessionFA.ValueMember = "Serial";
                    cmbSessionFA.DataSource = dsfa.Tables["Firearms"];
                    cmbResultsFA.DisplayMember = "FA";
                    cmbResultsFA.ValueMember = "Serial";
                    cmbResultsFA.DataSource = dsfa.Tables["Firearms"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured, LoadFAList!");
                }
            }
        }

        private void LoadAmmoList()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    string query = "SELECT Ammo.Brand+' '+Calibers.Caliber+' '+CONVERT(VARCHAR(20),Ammo.Weight)+'gr '+Ammo.Style AS Ammunition from Ammo,Calibers WHERE Ammo.Caliber='" + selectedFACaliber +"' AND Calibers.CalId ='" + selectedFACaliber +"';";
                    SqlDataAdapter daam = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet dsam = new DataSet();
                    daam.Fill(dsam, "Ammo");
                    cmbSessionAmmo.DisplayMember = "Ammunition";
                    cmbSessionAmmo.ValueMember = "Ammunition";
                    cmbSessionAmmo.DataSource = dsam.Tables["Ammo"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured, LoadAmmoList!");
                }
            }
        }

        private void cmbSessionAmmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT Ammo.AmmoId FROM Ammo,Calibers WHERE Ammo.Brand+' '+Calibers.Caliber+' '+CONVERT(VARCHAR(20),Ammo.Weight)+'gr '+Ammo.Style ='" + cmbSessionAmmo.Text + "';", conn);
                SqlDataReader calRdr = null;
                calRdr = cmd1.ExecuteReader();
                while (calRdr.Read())
                {
                    selectedAmmo = calRdr["AmmoId"].ToString();
                }
            }
        }

        private void cmbSessionFA_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT Serial,Caliber FROM Firearms WHERE Brand+' '+Model+' '+Serial ='" + cmbSessionFA.Text + "';", conn);
                SqlDataReader calRdr = null;
                calRdr = cmd1.ExecuteReader();
                while (calRdr.Read())
                {
                    selectedFA = calRdr["Serial"].ToString();
                    selectedFACaliber = calRdr["Caliber"].ToString();
                }
            }
            LoadAmmoList();
        }

        private void cmbResultsFA_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter darel = new SqlDataAdapter("SELECT Ammo,SUM(Failures) AS Failures,SUM(RoundCount) AS 'Round Count',(SUM(Failures)/SUM(RoundCount)) AS 'Failure Rate' FROM Sessions GROUP BY Ammo", ConnString);
            DataSet dsrel = new DataSet();
            darel.Fill(dsrel, "Sessions");
            dGVReliablility.DataSource = dsrel.Tables["Sessions"].DefaultView;

            SqlDataAdapter daacc = new SqlDataAdapter("SELECT Ammo,AVG(GroupSize) AS 'Average Group' FROM Sessions GROUP BY Ammo", ConnString);
            DataSet dsacc = new DataSet();
            daacc.Fill(dsacc, "Sessions");
            dGVAccuracy.DataSource = dsacc.Tables["Sessions"].DefaultView;
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Sessions(Date,Firearm,RangeName,Ammo,RoundCount,Failures,GroupSize,Distance)Values('" + dtDate.Text + "','" + selectedFA + "','" + tbRange.Text + "','"  + Convert.ToInt32(selectedAmmo) + "','" + NumRoundCount.Value.ToString() + "','" + Convert.ToInt32(numFailures.Value) + "','" + numGroupSize.Value.ToString() + "','" + numDistance.Value.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sessions", ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sessions");
            dataGridView4.DataSource = ds.Tables["Sessions"].DefaultView;
        }
    }
}
