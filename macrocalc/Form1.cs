namespace macrocalc
{
    public partial class Form1 : Form
    {
        public struct Cibo
        {
            public string nome;
            public float calorie;
            public float macro;
        }
        Cibo[] Cibi = new Cibo[14];

        public Form1()
        {
            InitializeComponent();
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StreamReader lettura = new StreamReader("cibi.csv");
            
            string a; int i = 0;
            while (!lettura.EndOfStream)
            {
                a = lettura.ReadLine();
                var b = a.Split(';'); Cibi[i].nome = b[0];
                Cibi[i].calorie = float.Parse(b[1]);
                Cibi[i].macro = float.Parse(b[2]);
                i++;
            }
        }
        private void uscita_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public float macro(Cibo[] ele,string nome)
        {
            for(int i = 0; i < ele.Length; i++)
            {
                if(ele[i].nome == nome)
                {
                    return ele[i].macro;
                }
            }
            return -1;
        }
        public float calorie(Cibo[] ele,string pro, string car, string gras, string fib)
        {
            float cal = 0;
            for(int i = 0; i < ele.Length; i++)
            {
                if(ele[i].nome == pro)
                {
                    cal += ele[i].calorie;
                }
                if (ele[i].nome == car)
                {
                    cal += ele[i].calorie;
                }
                if(ele[i].nome == gras)
                {
                    cal += ele[i].calorie;
                }
                if (ele[i].nome == fib)
                {
                    cal += ele[i].calorie;
                }
            }
            return cal;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (proteine.SelectedIndex == -1 || carbo.SelectedIndex == -1 || fibre.SelectedIndex == -1 || grassi.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("compila tutti i campi");
                return;
            }
            if(comboBox2.SelectedItem.ToString() == "Colazione")
            {
                ccolazione.Text =  calorie(Cibi, proteine.Text, carbo.Text, grassi.Text, fibre.Text).ToString();
                mpco.Text = macro(Cibi, proteine.Text).ToString();
                mfco.Text = macro(Cibi, fibre.Text).ToString();
                mgco.Text = macro(Cibi, grassi.Text).ToString();
                mcco.Text = macro(Cibi, carbo.Text).ToString();
            }
            if (comboBox2.SelectedItem.ToString() == "Pranzo")
            {
                cpranzo.Text = calorie(Cibi, proteine.Text, carbo.Text, grassi.Text, fibre.Text).ToString();
                mpp.Text = macro(Cibi, proteine.Text).ToString();
                mfp.Text = macro(Cibi, fibre.Text).ToString();
                mgp.Text = macro(Cibi, grassi.Text).ToString();
                mcp.Text = macro(Cibi, carbo.Text).ToString();

            }
            if (comboBox2.SelectedItem.ToString() == "Spuntino")
            {
                cspuntino.Text = calorie(Cibi, proteine.Text, carbo.Text, grassi.Text, fibre.Text).ToString();
                mps.Text = macro(Cibi, proteine.Text).ToString();
                mfs.Text = macro(Cibi, fibre.Text).ToString();
                mgs.Text = macro(Cibi, grassi.Text).ToString();
                mcs.Text = macro(Cibi, carbo.Text).ToString();
            }
            if (comboBox2.SelectedItem.ToString() == "Cena")
            {
                ccena.Text = calorie(Cibi, proteine.Text, carbo.Text, grassi.Text, fibre.Text).ToString();
                mpce.Text = macro(Cibi, proteine.Text).ToString();
                mfce.Text = macro(Cibi, fibre.Text).ToString();
                mgce.Text = macro(Cibi, grassi.Text).ToString();
                mcce.Text = macro(Cibi, carbo.Text).ToString();
            }
            float totc = float.Parse(ccolazione.Text) + float.Parse(cpranzo.Text) + float.Parse(cspuntino.Text) + float.Parse(ccena.Text);
            
            
            float tp = float.Parse(mpco.Text) + float.Parse(mpp.Text) + float.Parse(mps.Text) + float.Parse(mpce.Text);
            float tc = float.Parse(mcco.Text) + float.Parse(mcp.Text) + float.Parse(mcs.Text) + float.Parse(mcce.Text);
            float tg = float.Parse(mgco.Text) + float.Parse(mgp.Text) + float.Parse(mgs.Text) + float.Parse(mgce.Text);
            float tf = float.Parse(mfco.Text) + float.Parse(mfp.Text) + float.Parse(mfs.Text) + float.Parse(mfce.Text);
            ptot.Text = tp.ToString();
            ctot.Text = tc.ToString();
            gtot.Text = tg.ToString();
            ftot.Text = tf.ToString();
            allc.Text = totc.ToString();
        }

        private void Colazione_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Spuntino_Enter(object sender, EventArgs e)
        {

        }

        private void proteine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}