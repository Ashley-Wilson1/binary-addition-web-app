using ServiceReference1;

namespace WcfClientBinaryCalc
{
    public partial class Form1 : Form
    {
        Service1Client client;
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += MyClosedHandler;

            client = new Service1Client();
            
          
            

        }
        protected void MyClosedHandler(object sender, EventArgs e)
        {
            //closes the client to release all communication resources
            client.Close();
            Console.WriteLine("closed");
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            if(IsBinaryNumber(BinaryInput1.Text)&& IsBinaryNumber(BinaryInput2.Text))
            {
                //sets label to the output
                OutputLabel.Text = client.BinaryAdd(BinaryInput1.Text, BinaryInput2.Text);
            }
            else
            {
                //sets label to error message
                OutputLabel.Text = "Enter valid binary numbers";

            }
        }
        public static bool IsBinaryNumber(string input)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(input))
                return false;

            // Check if all characters in the string are either '0' or '1'
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }

            return true;
        }
    }
}
