using RestSharp;
using RotaProject.PostModels;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace RotaProject
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void PostRequest()
        {
            string url = "https://dummyjson.com/auth/login";

            var client = new RestClient(url);

            var request = new RestRequest();

            var postData = new PostData()
            {
                username = txtbxUsername.Text.ToString(),
                password = txtbxPassword.Text.ToString()
            };

            request.AddJsonBody(postData);

            var response = client.Post(request);

            if (response.IsSuccessStatusCode)
            {
                var postResponse = JsonSerializer.Deserialize<PostResponse>(response.Content.ToString());

                Debug.WriteLine("Status Code: " + response.StatusCode.ToString());
                Debug.WriteLine("Full Content: " + response.Content.ToString());
                Debug.WriteLine("\n******************\n\nId: " + postResponse.id.ToString());
                Debug.WriteLine("Username: " + postResponse.username);
                Debug.WriteLine("Email: " + postResponse.email);
                Debug.WriteLine("FirstName: " + postResponse.firstName);
                Debug.WriteLine("LastName: " + postResponse.lastName);
                Debug.WriteLine("Gender: " + postResponse.gender);
                Debug.WriteLine("Image: " + postResponse.image);
                Debug.WriteLine("Token: " + postResponse.token);

                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxUsername.Text.ToString() == "" || txtbxPassword.Text.ToString() == "")
                {
                    DialogResult result = MessageBox.Show("Username or password cannot be left blank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PostRequest();

                }

            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Username or password is incorrect. (" + ex.ToString() + ")", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}