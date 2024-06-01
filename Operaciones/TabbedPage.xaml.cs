using System;
namespace Operaciones;

public partial class TabbedPage : ContentPage
{
	public TabbedPage()
	{
		InitializeComponent();
	
	}
	private void CalculateSquareAreaButton_Clicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(squareSideEntry.Text))
		{
			DisplayAlert("Error", "Ingrese el lado del cuadrado", "OK");
			return;
		}

		double side;
		if (!double.TryParse(squareSideEntry.Text, out side))
		{
			DisplayAlert("Error", "Ingrese un valor num�rico v�lido", "OK");
			return;
		}

		double area = side * side;
		squareAreaLabel.Text = $"�rea: {area:F2}";
	}
	private void CalculateCircleAreaButton_Clicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(circleRadiusEntry.Text))
		{
			DisplayAlert("Error", "Ingrese el radio del c�rculo", "OK");
			return;
		}

		double radius;
		if (!double.TryParse(circleRadiusEntry.Text, out radius))
		{
			DisplayAlert("Error", "Ingrese un valor num�rico v�lido", "OK");
			return;
		}

		double area = Math.PI * radius * radius;
		circleAreaLabel.Text = $"�rea: {area:F2}";
	}

	private void ClearSquareButton_Clicked(object sender, EventArgs e)
	{
		squareSideEntry.Text = string.Empty;
		squareAreaLabel.Text = "�rea: ";
	}

	
	private void CalculateRectangleAreaButton_Clicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(rectangleWidthEntry.Text) || string.IsNullOrWhiteSpace(rectangleHeightEntry.Text))
		{
			rectangleWidthEntry.Text = string.Empty;
			rectangleHeightEntry.Text = string.Empty;

			DisplayAlert("Error", "Ingrese tanto el ancho como la altura del rect�ngulo", "OK");
			return;
		}
	}

	private void ClearCircleButton_Clicked(object sender, EventArgs e)
	{
		circleRadiusEntry.Text = string.Empty;
		circleAreaLabel.Text = string.Empty;
	}


}