using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace First_Form
{


    public partial class Form1 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "rNxXjAuTkXuJnVZiJtpDDfpKvFK0j4foiYFDio1o",
            BasePath = "https://criminals-of-feri-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //create a error message box
            MessageBox.Show("The date is " + dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show("Your time is going...");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // change font size of label1:
            welcome_message.Font = new Font("Arial", 24);
            // change font color of label1:
            welcome_message.ForeColor = Color.Red;

            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connected to Firebase database");
            }
            else
            {
                MessageBox.Show("Not connected to Firebase database");
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application created by Fahrettin Baştürk");
        }



        private void What_did_troll_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void Add_system_button_Click(object sender, EventArgs e)
        {
            //take name from the textbox6
            string user_nick = Discord_nick.Text;
            //take troll ıd from textbox
            string troll_id = Troll_id.Text;
            //take troll name from textbox
            string troll_nick = Troll_nick.Text;
            //take troll's action in the server:
            string troll_action = What_did_troll.Text;
            MessageBox.Show("id is: " + user_nick + "troll's id is: " + troll_id + "troll's nick is: " + troll_nick + "\n" 
                           + "he did: " + troll_action );
            DatabaseFunctions(user_nick, troll_id, troll_nick, troll_action);
        }

        private async void DatabaseFunctions(string user_nick, string troll_id, string troll_nick, string troll_action){

            //create a new object of FirebaseResponse
            User user = new User
            {
                Reporter_nick = user_nick,
                Troll_id = troll_id,
                Troll_nick = troll_nick,
                Troll_action = troll_action
            };

            SetResponse response = await client.SetTaskAsync("users/" + troll_id, user);
            User result = response.ResultAs<User>();

            if (result != null)
            {
                MessageBox.Show("Successfully added to database for " + user_nick);
            }
            else
            {
                MessageBox.Show("Not added to database");
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //take data from the database and show it in the listbox

        }
    }
}
