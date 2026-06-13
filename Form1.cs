namespace TODO_List
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !string.IsNullOrWhiteSpace(textBox1.Text))
            {

                // ajouter un item a checkedListBox

                checkedListBox1.Items.Add(textBox1.Text.Trim() + "                        📍📍📍📍📍📍📍📍📍📍📍📍📍📍📍📍📍📍                    " + DateTime.Now.ToString("dddd-dd-MMMM-yyyy HH:mm:ss"));
                textBox1.Clear();
                // afficher un texte dans le 4e label qui indique le nombre de taches dans checkedListBox

                label4.Text = checkedListBox1.Items.Count.ToString() + " Tache(s)";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                var item = checkedListBox1.CheckedItems[0];
                if (item != null)
                {
                    checkedListBox1.Items.Remove(item);
                    label4.Text = checkedListBox1.Items.Count.ToString() + " Tache(s)";
                }
                else
                {
                    // Si l'élément est null, sortir pour éviter une boucle infinie
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            label4.Text = " 0 Tache(s)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem != null)
            {
                // ajouter du contenu a un item checkedListBox

                checkedListBox1.Items[checkedListBox1.SelectedIndex] =

                    checkedListBox1.Items[checkedListBox1.SelectedIndex].ToString() + "     ✔️";

            }
        }
    }
}
