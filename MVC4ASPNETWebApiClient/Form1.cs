using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;
using System.IO;

namespace MVC4ASPNETWebApiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        WebRequest getRequest(string method, string contentType, string endPoint)
        {
            var request = WebRequest.Create(endPoint);
            request.Method = method;
            request.ContentType = contentType;

            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            RSAClass.ChiavePrivata = txtChiavePrivata.Text;
            RSAClass.ChiavePubblica = txtChiavePubblica.Text;

            request.Headers.Add("Authorization-Token", RSAClass.Encrypt(String.Format("{0};{1};{2}", txtTokenFisso.Text, txtTokenVariabile.Text, txtURL.Text)));

            return request;
        }

        String unPackResponse(WebResponse response)
        {
            var dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);
            return reader.ReadToEnd();
        }

        private void bttPulisci_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private bool RichiestaConChiave(out HttpWebResponse response)
        {
            response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txtURL.Text);

                request.ContentType = "application/json";
                request.Headers.Add("Authorization-Token", txtHEXChiave.Text);

                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError) response = (HttpWebResponse)e.Response;
                else return false;
            }
            catch (Exception)
            {
                if (response != null) response.Close();
                return false;
            }

            return true;
        }

        private void bttGeneraChiavi_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSACryptoServiceProvider(2048);
            txtChiavePrivata.Text = rsa.ToXmlString(true);
            txtChiavePubblica.Text = rsa.ToXmlString(false);
            txtTokenFisso.Text = Guid.NewGuid().ToString("D").ToUpper();
            txtTokenVariabile.Text = Guid.NewGuid().ToString("D").ToUpper();
        }

        private void bttStandardTest_Click(object sender, EventArgs e)
        {
            try
            {

                // Cambia il token variabile
                if (chkTokenVariabile.Checked == true)
                    txtTokenVariabile.Text = Guid.NewGuid().ToString("D").ToUpper();

                var request = this.getRequest("GET", "application/json", txtURL.Text);
                HttpWebResponse response;

                try
                {
                    response = request.GetResponse() as HttpWebResponse;
                    textBox1.Text = unPackResponse(response);
                }
                catch (WebException ex)
                {
                    response = ex.Response as HttpWebResponse;
                    textBox1.Text = unPackResponse(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttHackTest_Clink(object sender, EventArgs e)
        {
            try
            {
                HttpWebResponse response;

                if (RichiestaConChiave(out response))
                {
                    textBox1.Text = unPackResponse(response);
                    response.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
