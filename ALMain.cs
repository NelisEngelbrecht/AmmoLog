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
        static string ConnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AmmoLogDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con   = new SqlConnection(ConnString);
        public ALMain()
        {
            InitializeComponent();

            LoadFAList();
            LoadCaliberList();
            LoadAmmoList();
            LoadSessionData();
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
            dgvFA.DataSource = ds.Tables["Firearms"].DefaultView;
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
                finally
                {
                    conn.Close();
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
                finally
                {
                    conn.Close();
                }

                SqlDataAdapter dagridfa = new SqlDataAdapter("SELECT f.Brand,f.Model,f.Serial,c.Caliber FROM Firearms f INNER JOIN Calibers c ON f.Caliber=c.CalId", ConnString);
                DataSet dsgridfa = new DataSet();
                dagridfa.Fill(dsgridfa, "Firearms");
                dgvFA.DataSource = dsgridfa.Tables["Firearms"].DefaultView;
            }
        }

        private void LoadAmmoList()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                try
                {
                    string query = "SELECT a.AmmoId,a.Brand+' '+c.Caliber+' '+CONVERT(VARCHAR(20),a.Weight)+'gr '+a.Style AS Ammunition FROM Ammo a INNER JOIN Calibers c ON a.Caliber='" + cmbAmmoCaliber.SelectedValue +"' AND c.CalId ='" + cmbAmmoCaliber.SelectedValue + "';";
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
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoadSessionData()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT f.Brand+' '+f.Model+' '+f.Serial AS Firearm, a.Brand+' '+CONVERT(VARCHAR(20),a.Weight)+'gr '+a.Style AS Ammunition, RoundCount, Failures, GroupSize, Distance, RangeName, Date FROM Sessions s INNER JOIN Firearms f ON s.Firearm=f.Serial INNER JOIN Ammo a ON a.AmmoId=s.Ammo", ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "Sessions");
                dgvSession.DataSource = ds.Tables["Sessions"].DefaultView;
            }
        }

        private void cmbSessionFA_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAmmoList();
        }

        private void cmbResultsFA_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter daRel = new SqlDataAdapter("SELECT a.Brand+' '+CONVERT(VARCHAR(20),a.Weight)+'gr '+a.Style AS 'Ammunition',SUM(Failures) AS Failures,SUM(RoundCount) AS 'Round Count',(SUM(Failures)/SUM(RoundCount)) AS 'Failure Rate' FROM Sessions s INNER JOIN Ammo a ON s.Ammo=a.AmmoId WHERE s.Firearm = '" + cmbResultsFA.SelectedValue + "' GROUP BY s.Ammo,a.Brand,a.Weight,a.Style ORDER BY 'Failure Rate' ASC", ConnString);
            DataSet dsRel = new DataSet();
            daRel.Fill(dsRel, "Sessions");
            dgvReliablility.DataSource = dsRel.Tables["Sessions"].DefaultView;

            SqlDataAdapter daAcc = new SqlDataAdapter("SELECT a.Brand+' '+CONVERT(VARCHAR(20),a.Weight)+'gr '+a.Style AS 'Ammunition',AVG(s.GroupSize) AS 'Average Group' FROM Sessions s INNER JOIN Ammo a ON s.Ammo=a.AmmoId WHERE s.Firearm = '" + cmbResultsFA.SelectedValue + "' GROUP BY s.Ammo,a.Brand,a.Weight,a.Style ORDER BY 'Average Group' ASC", ConnString);
            DataSet dsAcc = new DataSet();
            daAcc.Fill(dsAcc, "Sessions");
            dgvAccuracy.DataSource = dsAcc.Tables["Sessions"].DefaultView;
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Sessions(Date,Firearm,RangeName,Ammo,RoundCount,Failures,GroupSize,Distance)Values('" + dtDate.Text + "','" + cmbSessionFA.SelectedValue + "','" + tbRange.Text + "','"  + Convert.ToInt32(cmbSessionAmmo.SelectedValue) + "','" + NumRoundCount.Value.ToString() + "','" + Convert.ToInt32(numFailures.Value) + "','" + numGroupSize.Value.ToString() + "','" + numDistance.Value.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            LoadSessionData();
        }
    }
}
