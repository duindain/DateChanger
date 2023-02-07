﻿namespace DateChanger;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		System.Diagnostics.Debug.WriteLine($"Date picked is {e.NewDate}");
    }
}

