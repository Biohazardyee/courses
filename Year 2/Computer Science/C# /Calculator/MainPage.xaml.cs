namespace Calculator;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


	private void BtnSeven_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "7";
		}
		else LblDisplay.Text += "7";
	}

	private void BtnEight_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "8";
		}
		else LblDisplay.Text += "8";
	}

	private void BtnNine_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "9";
		}
		else LblDisplay.Text += "9";
	}

	private void BtnDivide_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "÷";
		}
		else LblDisplay.Text += "÷";
	}

	private void BtnFour_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "4";
		}
		else LblDisplay.Text += "4";
	}

	private void BtnFive_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "5";
		}
		else LblDisplay.Text += "5";
	}

	private void BtnSix_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "6";
		}
		else LblDisplay.Text += "6";
	}

	private void BtnMultiply_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "×";
		}
		else LblDisplay.Text += "×";
	}

	private void BtnOne_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "1";
		}
		else LblDisplay.Text += "1";
	}

	private void BtnTwo_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "2";
		}
		else LblDisplay.Text += "2";
	}

	private void BtnThree_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "3";
		}
		else LblDisplay.Text += "3";
	}

	private void BtnMinus_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "-";
		}
		else LblDisplay.Text += "-";
	}

	private void BtnZero_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "0";
		}
		else LblDisplay.Text += "0";
	}

	private void BtnDecimal_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = ".";
		}
		else LblDisplay.Text += ".";
	}

	private void BtnPlus_Clicked(object sender, EventArgs e)
	{
		if (LblDisplay.Text == "0")
		{
			LblDisplay.Text = "+";
		}
		else LblDisplay.Text += "+";
	}

	private void BtnEquals_Clicked(object sender, EventArgs e)
	{
		// This is where the calculation logic will go
		if (LblDisplay.Text == "0")
		{
			return;
		}
		else
		{
			
		}
	}

	private void BtnClear_Clicked(object sender, EventArgs e)
	{
		LblDisplay.Text = "0";
	}


}
