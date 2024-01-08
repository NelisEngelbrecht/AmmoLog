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
    public partial class ALMain : Form
    {
        static string ConnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Users\\nelis\\source\\repos\\AmmoLog\\AmmoLogDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con   = new SqlConnection(ConnString);
        string selectedFACaliber,selectedFA,selectedAmmo;
        public ALMain()
        {
            InitializeComponent();

            LoadFAList();
            LoadCaliberList();
            LoadAmmoList();
            LoadSessionData();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Firearms", ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Firearms");
            dataGridView1.DataSource = ds.Tables["Firearms"].DefaultView;
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Sessions", ConnString);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "Sessions");
            dataGridView1.DataSource = ds1.Tables["Sessions"].DefaultView;
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
            SqlCommand cmd = new SqlCommand("INSERT INTO Ammo(Brand,Caliber,Weight,Style) Values('" + tbAmmoBrand.Text + "','" + cmbAmmoCaliber.SelectedValue + "','" + Convert.ToInt32(numAmmoWeight.Value) + "','" + cmbAmmoStyle.Text + "')", con);
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
                    SqlDataAdapter daListC = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet dsListC = new DataSet();
                    daListC.Fill(dsListC, "Calibers");
                    cmbFACaliber.DisplayMember = "Caliber";
                    cmbFACaliber.ValueMember = "CalId";
                    cmbFACaliber.DataSource = dsListC.Tables["Calibers"];
                    cmbAmmoCaliber.DisplayMember = "Caliber";
                    cmbAmmoCaliber.ValueMember = "CalId";
                    cmbAmmoCaliber.DataSource = dsListC.Tables["Calibers"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured, LoadCaliberList!" + ex.ToString());
                }
            }
        }

        private void LoadFAList()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    string query = "SELECT Serial, Brand+' '+Model+' '+Serial AS FA from Firearms";
                    SqlDataAdapter daListFa = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet dsListFa = new DataSet();
                    daListFa.Fill(dsListFa, "Firearms");
                    cmbSessionFA.DisplayMember = "FA";
                    cmbSessionFA.ValueMember = "Serial";
                    cmbSessionFA.DataSource = dsListFa.Tables["Firearms"];
                    cmbResultsFA.DisplayMember = "FA";
                    cmbResultsFA.ValueMember = "Serial";
                    cmbResultsFA.DataSource = dsListFa.Tables["Firearms"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured, LoadFAList!" + ex.ToString());
                }

                SqlDataAdapter dagridfa = new SqlDataAdapter("SELECT f.Brand,f.Model,f.Serial,c.Caliber FROM Firearms f INNER JOIN Calibers c ON f.Caliber=c.CalId", ConnString);
                DataSet dsgridfa = new DataSet();
                dagridfa.Fill(dsgridfa, "Firearms");
                dataGridView1.DataSource = dsgridfa.Tables["Firearms"].DefaultView;
            }
        }

        private void LoadAmmoList()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    string query = "SELECT a.AmmoId,a.Brand+' '+c.Caliber+' '+CONVERT(VARCHAR(20),a.Weight)+'gr '+a.Style AS Ammunition FROM Ammo a INNER JOIN Calibers c ON a.Caliber='" + selectedFACaliber +"' AND c.CalId ='" + selectedFACaliber +"';";
                    SqlDataAdapter daListA = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet dsListA = new DataSet();
                    daListA.Fill(dsListA, "Ammo");
                    cmbSessionAmmo.DisplayMember = "Ammunition";
                    cmbSessionAmmo.ValueMember = "AmmoId";
                    cmbSessionAmmo.DataSource = dsListA.Tables["Ammo"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured, LoadAmmoList!" + ex.ToString());
                }
            }
        }

        private void LoadSessionData()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT f.Brand+' '+f.Model+' '+f.Serial AS Firearm, a.Brand+' '+CONVERT(VARCHAR(20),a.Weight)+'gr '+a.Style AS Ammunition, RoundCount, Failures, GroupSize, Distance, RangeName, Date FROM Sessions s,Firearms f,Ammo a WHERE s.Firearm=f.Serial AND a.AmmoId=s.Ammo", ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "Sessions");
                dataGridView4.DataSource = ds.Tables["Sessions"].DefaultView;
            }
        }

        private void cmbSessionAmmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbSessionAmmo.SelectedValue.ToString());
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT a.AmmoId FROM Ammo a,Calibers c WHERE a.Brand+' '+c.Caliber+' '+CONVERT(VARCHAR(20),a.Weight)+'gr '+a.Style ='" + cmbSessionAmmo.Text + "';", conn);
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
            SqlDataAdapter darel = new SqlDataAdapter("SELECT Ammo,SUM(Failures) AS Failures,SUM(RoundCount) AS 'Round Count',(SUM(Failures)/SUM(RoundCount)) AS 'Failure Rate' FROM Sessions s WHERE s.Firearm = '" + cmbResultsFA.SelectedValue + "' GROUP BY Ammo ORDER BY 'Failure Rate' ASC", ConnString);
            DataSet dsrel = new DataSet();
            darel.Fill(dsrel, "Sessions");
            dGVReliablility.DataSource = dsrel.Tables["Sessions"].DefaultView;

            SqlDataAdapter daacc = new SqlDataAdapter("SELECT Ammo,AVG(GroupSize) AS 'Average Group' FROM Sessions s WHERE s.Firearm = '" + cmbResultsFA.SelectedValue + "' GROUP BY Ammo ORDER BY 'Average Group' ASC", ConnString);
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

            LoadSessionData();
        }
    }
}
