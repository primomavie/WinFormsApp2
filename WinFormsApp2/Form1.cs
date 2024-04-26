using System.Collections;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayList day = new ArrayList();
            for (int i = 0; i < 31; i++)
            {
                day.Add(i);
                cb1.Items.Add(day[i]);
            }

            String[] m = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", };
            cb2.Items.AddRange(m);
            foreach (string months in m)
            {
                Console.WriteLine(months);
            }
            ArrayList y = new ArrayList();
            for (int i = 1900; i <= 2024; i++)
            {
                y.Add(i);
                cb3.Items.Add(y[i - 1900]);
            }

            ArrayList p = new ArrayList();
            p.Add("Bachelor of Science in Education major in Math");
            p.Add("Bachelor of Science in Education major in ");
            p.Add("Bachelor of Science in Education major in Science");
            p.Add("Bachelor of Science in Education major in Mapeh");
            p.Add("Bachelor of Science in Information Technology");
            cb4.Items.AddRange(p.ToArray());
            foreach (String pName in p)
            {
                Console.WriteLine(pName);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            String f = t1.Text;
            String l = t2.Text;
            String mn = t3.Text;

            String g = radioButton1.Checked == true ? "Male" : "Female";

            String day = cb1.GetItemText(cb1.SelectedItem);
            String m = cb2.GetItemText(cb2.SelectedItem);
            String y = cb3.GetItemText(cb3.SelectedItem);
            
            String p = cb4.Text;

            RegisterStudent (l, f, mn, g, day, m, y, p);
            RegisterStudent (l, f, mn, p);
            RegisterStudent (l, f, p);
        }
        public void RegisterStudent(String l, String f, String mn, String g, String day, String m, String y, String p)
        {
            MessageBox.Show("Student name: " + f +" "+ mn+" " + l+ "\nGender: " + g + "\nDate of Birth: " + day +" "+ m +" "+ y + "\nProgram: " + p);
        }
        public void RegisterStudent(String l, String f, String mn, String p)
        {
            MessageBox.Show("Student name: " + f + " "+mn +" "+ l + "\nProgram: " + p);
        }
        public void RegisterStudent(String l, String f, String p )
        {
            MessageBox.Show("Student name: " + f +" "+ l + "\nProgram: "+p );
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
