using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ogrodnik_lab2
{
    public partial class Form1 : Form
    {
        private DancersDBContext dbContext;
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            dbContext = new DancersDBContext();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string call;
            var userId = IdBox.Text;
            if (userId == "")
                userId = "0";

            if (userId == "0")
            {
                ActionForNullId();
                return;
            }


            if (CheckIfDataIsInDatabase(Int32.Parse(userId)))
            {
                var dancer = dbContext.Dancerss.FirstOrDefault(x => x.id == Int32.Parse(userId));
                textBoxResponse.Text = dancer.ToString();
                return;
            }

            call = ("https://localhost:7234/dancer/" + userId);
            string response;
            try
            {
                response = await client.GetStringAsync(call);
            }
            catch
            {
                MessageBox.Show("Dancer Not Found");
                textBoxResponse.Text = "Not Found";
                return;
            }
            DancerDB userDancer = JsonSerializer.Deserialize<DancerDB>(response);
            textBoxResponse.Text = userDancer.ToString();

            dbContext.Add(userDancer);
            dbContext.SaveChanges();
        }


        private bool CheckIfDataIsInDatabase(int id)
        {
            bool result = true;
            if (id == 0)
            {
               var item = dbContext
                .Dancerss
                .ToList();
                if (item is null)
                    result = false;
            }
            else 
            {
              var item = dbContext
                .Dancerss
                .FirstOrDefault(x => x.id == id);
               if (item is null)
                   result = false;
            }

            return result;
        }
        

        private async void ActionForNullId()
        {
            string text = "";
            if (CheckIfDataIsInDatabase(Int32.Parse("0")))
            {
                var items = dbContext.Dancerss.ToList();
                items = Filter();
                foreach (var dancer in items)
                    text += (dancer.ToString() + "\n");
                text = text.ToString().Replace("\n", Environment.NewLine);
                textBoxResponse.Text = text;
                return;
            }

            string call;
            call = ("https://localhost:7234/dancer");
            string response;
            try
            {
                response = await client.GetStringAsync(call);
            }
            catch
            {
                MessageBox.Show("Dancer Not Found");
                textBoxResponse.Text = "Not Found";
                return;
            }
            List<DancerDB> Dancers = JsonSerializer.Deserialize<List<DancerDB>>(response);

            Dancers = Filter();

            foreach (var dancer in Dancers)
                text += (dancer.ToString() + "\n");
            text = text.ToString().Replace("\n", Environment.NewLine);
            textBoxResponse.Text = text;

            dbContext.AddRange(Dancers);
            dbContext.SaveChanges();
        }


        private List<DancerDB> FilterById(string text_id)
        {
            string sign;
            string number = "";
            string tekst = Id_filter_text.Text;
            if (tekst[1] == '=')
            {
                sign = (tekst[0].ToString() + '=');
                for (int i = 2; i < tekst.Length; i++)
                    number += tekst[i].ToString();
            }
            else
            {
                sign = tekst[0].ToString();
                for (int i = 1; i < tekst.Length; i++)
                    number += tekst[i].ToString();
            }

            int int_number = Int32.Parse(number);
            var Dancers = new List<DancerDB>();
            switch (sign)
            {
                case "<":
                    Dancers = dbContext.Dancerss.Where(x => x.id < int_number).ToList();
                    break;
                case ">":
                    Dancers = dbContext.Dancerss.Where(x => x.id > int_number).ToList();
                    break;
                case "<=":
                    Dancers = dbContext.Dancerss.Where(x => x.id <= int_number).ToList();
                    break;
                case ">=":
                    Dancers = dbContext.Dancerss.Where(x => x.id >= int_number).ToList();
                    break;
                default:
                    textBoxResponse.Text = "Not Found";
                    break;
            }

            return Dancers;
        }
        private List<DancerDB> FilterByDanceClass(string danceClass)
        {
            var result = dbContext
                .Dancerss
                .Where(x => x.danceclass == danceClass)
                .ToList();
            return result;
        }

        private List<DancerDB> Filter()
        {
            var Dancers = dbContext.Dancerss.ToList();
            foreach (var item in DancerCheckBox.CheckedItems)
            {
                if (item.ToString() == "Id")
                {
                    Dancers = FilterById(Id_filter_text.Text);
                }
                if (item.ToString() == "DanceClass")
                {
                    Dancers = FilterByDanceClass(DanceClassComboBox.Text);
                }
            }
            if (Dancers == null)
                textBoxResponse.Text = "Not Found";
            return Dancers;
        }

        private void DancerCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in DancerCheckBox.CheckedItems)
            {
                if(item.ToString() == "Id")
                {
                    Id_filter_text.Visible = true;
                    FiltrId_label.Visible = true;
                }
                if (item.ToString() == "DanceClass")
                {
                    DanceClassComboBox.Visible = true;
                    DanceClass_selected_label.Visible = true;
                }
            }

            foreach (var item in DancerCheckBox.Items)
            {
                var state = DancerCheckBox.GetItemCheckState(DancerCheckBox.SelectedIndex);
                if (state == CheckState.Unchecked)
                {
                    if (item.ToString() == "Id")
                    {
                        Id_filter_text.Visible = false;
                        FiltrId_label.Visible = false;
                    }
                    if (item.ToString() == "DanceClass")
                    {
                        DanceClassComboBox.Visible = false;
                        DanceClass_selected_label.Visible = false;
                    }
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                DancerCheckBox.Visible = true;
            else
                DancerCheckBox.Visible = false;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxResponse.Clear();
        }
        private async void Update_Click(object sender, EventArgs e)
        {
            string call = ("https://localhost:7234/dancer");
            string response = await client.GetStringAsync(call);
            List<DancerDB> Dancers = JsonSerializer.Deserialize<List<DancerDB>>(response);

            var existedDancers = dbContext.Dancerss.ToList();
            dbContext.RemoveRange(existedDancers);
            dbContext.SaveChanges();

            dbContext.AddRange(Dancers);
            dbContext.SaveChanges();

            textBoxResponse.Text = "Done";

        }
        private void IdBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(IdBox.Text, out result) || IdBox.Text == "")
            {
                IdBox.ForeColor = Color.Red;
                buttonDownload.Enabled = false;
            }
            else
            {
                IdBox.ForeColor = Color.Black;
                buttonDownload.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SortButton_Click(object sender, EventArgs e)
        {

        }
        private void EndpointBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Dupa");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}