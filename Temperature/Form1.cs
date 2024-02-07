namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double Temperature = Convert.ToDouble(txtTemperature.Text);
                double Celcius, Fahrenheit;
                lblResult.Text = "";
                if (rbtCelcius.Checked == true)
                {
                    Celcius = Convert.ToDouble(Temperature - 32) * 5 / 9;
                    lblResult.Text = ("C: " + Convert.ToString(String.Format("{0:0.00}", Celcius)));
                }
                else if (rbtFahrenheit.Checked == true)
                {
                    Fahrenheit = (Temperature * 9 / 5) + 32;
                    lblResult.Text = ("F: " + Convert.ToString(String.Format("{0:0.00}", Fahrenheit)));
                }
                else
                {
                    lblResult.Text = "Select Celcius or Fahrenheit";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }





        }
    }
}