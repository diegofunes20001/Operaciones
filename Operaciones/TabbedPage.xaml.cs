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
			DisplayAlert("Error", "Ingrese un valor numérico válido", "OK");
			return;
		}

		double area = side * side;
		squareAreaLabel.Text = $"Área: {area:F2}";
	}
	private void CalculateCircleAreaButton_Clicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(circleRadiusEntry.Text))
		{
			DisplayAlert("Error", "Ingrese el radio del círculo", "OK");
			return;
		}

		double radius;
		if (!double.TryParse(circleRadiusEntry.Text, out radius))
		{
			DisplayAlert("Error", "Ingrese un valor numérico válido", "OK");
			return;
		}

		double area = Math.PI * radius * radius;
		circleAreaLabel.Text = $"Área: {area:F2}";
	}

	private void ClearSquareButton_Clicked(object sender, EventArgs e)
	{
		squareSideEntry.Text = string.Empty;
		squareAreaLabel.Text = "Área: ";
	}

	
	private void CalculateRectangleAreaButton_Clicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(rectangleWidthEntry.Text) || string.IsNullOrWhiteSpace(rectangleHeightEntry.Text))
		{
			rectangleWidthEntry.Text = string.Empty;
			rectangleHeightEntry.Text = string.Empty;

			DisplayAlert("Error", "Ingrese tanto el ancho como la altura del rectángulo", "OK");
			return;
		}
	}

	private void ClearCircleButton_Clicked(object sender, EventArgs e)
	{
		circleRadiusEntry.Text = string.Empty;
		circleAreaLabel.Text = string.Empty;
	}


}