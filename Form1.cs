namespace RollerCoasterRide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //I'm afraid to clean this up
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        // Texts Holders, Knights of letters and Sons of the Alphabet II
        // Strings for backTrouble and heartTrouble textboxes
        string backTrouble, heartTrouble;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // If we can not parse user input user gets message
            if (!int.TryParse(txtHeight.Text, out int height))
            {
                MessageBox.Show("Height only in centimeters");
                return;
            }
            // Height Check
            if (height < 122 || height > 188)
            {
                MessageBox.Show("Ho-ho-ho. \nNO, little dwarf");
                return;
            }
            // Troubles Check
            if (backTrouble == "N" || heartTrouble == "N")
            {
                MessageBox.Show("You are allowed to ride the roller coaster!");
                return;
            }
            // Funny message
            else
                MessageBox.Show("You will die. \nWe can not allow you to kill yourself on OUR roller voaster");
        }
        // Do you even read the comments? 
        // Okay then I'll tell you something...
        // Something that you would never have known without this comment.
        // ...
        // This function check if our visitor has Heart Troubles
        private void txtHeartTrouble_TextChanged(object sender, EventArgs e)
        {
            heartTrouble = txtHeartTrouble.Text.Trim().ToUpper();
        }
        // Andt this function check if our visitor has Back Troubles
        private void txtBackTrouble_TextChanged(object sender, EventArgs e)
        {
            backTrouble = txtBackTrouble.Text.Trim().ToUpper();
        }
    }
}