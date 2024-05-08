using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FirstPage.BringToFront();
		}

		private void Owner_btn_Click(object sender, EventArgs e)
		{
			OwnerCreateAccount.BringToFront();
		}

		private void OwnerLogin_label_Click(object sender, EventArgs e)
		{
			OwnerLogin.BringToFront();
		}

		private void createAccount_label_Click(object sender, EventArgs e)
		{
			OwnerCreateAccount.BringToFront();
		}

		private void Customer_btn_Click(object sender, EventArgs e)
		{
			CustomerCreateAccount.BringToFront();
		}

		private void customerLogin_label_Click(object sender, EventArgs e)
		{
			CustomerLogin.BringToFront();
		}

		private void customerCreateAccount_label_Click(object sender, EventArgs e)
		{
			CustomerCreateAccount.BringToFront();
		}

		private void owner_logOut_button_Click(object sender, EventArgs e)
		{
			FirstPage.BringToFront();
		}

		private void customerLogOut_button_Click(object sender, EventArgs e)
		{
			FirstPage.BringToFront();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			CustomerHomePage.BringToFront();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CustomerHomePage.BringToFront();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			OwnerHomePage.BringToFront();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OwnerHomePage.BringToFront();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ShowOrderInfo.BringToFront();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			FirstPage.BringToFront();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			CustomerHomePage.BringToFront();
		}


		private void loadProduct_btn_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}


		private void button6_Click(object sender, EventArgs e)
		{

		}


		private void button8_Click(object sender, EventArgs e)
		{

		}

	}
}
