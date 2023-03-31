namespace ScrollViewPan;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        var rotation = scrollView.Rotation + 90;
        if (rotation == 360)
        {
            rotation = 0;
        }

        scrollView.Rotation = rotation;
    }
}

