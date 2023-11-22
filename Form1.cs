namespace ABB_Trial_Read
{
    using System;
    using System.Threading;
    using Opc.UaFx.Client;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();


                var Pressure1 = client.ReadNode("ns=2;i=4");
                Console.WriteLine("Current Pressure is {0} °C", Pressure1);
                textBox1.Text = Pressure1.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();
                long Pressure1;
                Pressure1 = Convert.ToInt64(textBox2.Text);
                client.WriteNode("ns=2;i=4", Pressure1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();


                var Pressure2 = client.ReadNode("ns=2;i=5");
                Console.WriteLine("Current Pressure2 is {0} °C", Pressure2);
                textBox3.Text = Pressure2.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();
                long Pressure2;
                Pressure2 = Convert.ToInt64(textBox4.Text);
                client.WriteNode("ns=2;i=5", Pressure2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();


                var temperature1 = client.ReadNode("ns=2;i=2");
                Console.WriteLine("Current Temperature1 is {0} °C", temperature1);
                textBox5.Text = temperature1.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();
                long temperature1;
                temperature1 = Convert.ToInt64(textBox6.Text);
                client.WriteNode("ns=2;i=2", temperature1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();


                var temperature2 = client.ReadNode("ns=2;i=3");
                Console.WriteLine("Current Temperature2 is {0} °C", temperature2);
                textBox7.Text = temperature2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var client = new OpcClient("opc.tcp://127.0.0.1:4840"))
            {
                client.Connect();
                long temperature2;
                temperature2 = Convert.ToInt64(textBox8.Text);
                client.WriteNode("ns=2;i=3", temperature2);
            }
        }
    }
}