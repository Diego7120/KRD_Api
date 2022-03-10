using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KRD_Api.Chase;

namespace KRD_Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rad_cert_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_cert.Checked)
            {
                gr_login.Visible = false;
            }
        }

        private void rad_login_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_login.Checked)
            {
                gr_login.Visible = true;
            }
        }

        private void bt_spr_firme_Click(object sender, EventArgs e)
        {
            try
            { 
            bool loginViaCert = rad_cert.Checked;
            SearchClient sc = new SearchClient(loginViaCert ? "ChaseCert" : "ChaseLogin");
            sc.Open();
            DisclosureReport dr = new DisclosureReport();
            RequestAuthorizationHeader auth = new RequestAuthorizationHeader();
            if (loginViaCert)
            {
                auth.AuthorizationType = AuthorizationType.Certificate;
            }
            else
            {
                auth.AuthorizationType = AuthorizationType.LoginAndPassword;
                auth.Login = tb_login.Text;
                auth.Password = tb_pass.Text;
            }

            try
            {
                sc.SearchNonConsumer(auth, tx_numer.Text, NonConsumerNumberType.TaxId, out dr);


                tx_results.Text += dr.Created.ToString();
                    tx_results.Text += " ";
                    tx_results.Text += dr.Number;
                if (dr.SearchCriterion.ConsumerIdentityNumber != null)
                        {
                        tx_results.Text += " Pesel:" + dr.SearchCriterion.ConsumerIdentityNumber.Item;
                        tx_results.Text += " Liczba informacji:" + dr.Summary.InformationCount;
                        tx_results.Text += " Liczba informacji pozytywnych:" + dr.PositiveInformationSummary.PaidObligationsCount;
                        tx_results.Text += " Suma zobowiązań:" + dr.Summary.TotalArrears.Amount + " " + dr.Summary.TotalArrears.Amount;
                        }
                    else
                    {
                        tx_results.Text += " BRAK DANYCH ";
                    }
                    tx_results.Text += "\r\n";

                }
            catch (Exception err)
            {
                    MessageBox.Show(err.Message);
            }
            
            sc.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void br_spr_kons_Click(object sender, EventArgs e)
        {
            try
            { 
            bool loginViaCert = rad_cert.Checked;
            SearchClient sc = new SearchClient(loginViaCert ? "ChaseCert" : "ChaseLogin");
            sc.Open();
            DisclosureReport dr = new DisclosureReport();
            RequestAuthorizationHeader auth = new RequestAuthorizationHeader();
            if (loginViaCert)
            {
                auth.AuthorizationType = AuthorizationType.Certificate;
            }
            else
            {
                auth.AuthorizationType = AuthorizationType.LoginAndPassword;
                auth.Login = tb_login.Text;
                auth.Password = tb_pass.Text;
            }

            try
                {
                sc.SearchConsumer(auth, tx_numer.Text, ConsumerNumberType.Pesel, monthCalendar1.SelectionStart, out dr);

                string text_result = dr.Number;
                text_result += " Pesel:" + dr.SearchCriterion.ConsumerIdentityNumber.Item;
                text_result += " Liczba informacji:" + dr.Summary.InformationCount;
                text_result += " Liczba informacji pozytywnych:" + dr.PositiveInformationSummary.PaidObligationsCount;
                text_result += " Suma zobowiązań:" + dr.Summary.TotalArrears.Amount + " " + dr.Summary.TotalArrears.Amount;

                tx_results.Text = text_result;
                }
            catch (Exception err)
            {

                    MessageBox.Show(err.Message);
                }
            
            sc.Close();
            
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
