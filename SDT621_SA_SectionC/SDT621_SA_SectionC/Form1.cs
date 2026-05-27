namespace SDT621_SA_SectionC
{
    public partial class Form1 : Form
    {
        List<Mobile> Mobiles = new List<Mobile>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Mobile mobile = new Mobile();
            mobile.Code = txtCode.Text;
            mobile.Make = txtMake.Text;
            mobile.Quantity = txtQuantity.Text;
            Mobiles.Add(mobile);

            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (Mobile mobile in Mobiles)
                if (txtCode.Text == mobile.Code)
                {
                    Mobiles.Remove(mobile);
                    lblOutput.Text = "Record deleted";
                    break;
                } 
                else
                {
                    lblOutput.Text = "Record NOT found";
                }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            foreach (Mobile mobile in Mobiles)
                if (txtCode.Text == mobile.Code)
                {
                    lblOutput.Text = "Record Found";
                    break;
                } 
                else
                {
                    lblOutput.Text = "Record NOT found";
                }
        }
    }
}
