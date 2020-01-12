using System;
using Gtk;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;



public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();


		soupName.Visible = false;
		soup.Visible = false;
		soupPrice.Visible = false;

		specialName.Visible = false;
		special.Visible = false;
		specialPrice.Visible = false;

		fishName.Visible = false;
		fish.Visible = false;
		fishPrice.Visible = false;

	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnExitButtonClicked(object sender, EventArgs e)
	{
		Application.Quit();
	}



	protected void OnSoupButtonClicked(object sender, EventArgs e)
	{
		soupName.Visible = true;
		soup.Visible = true;
		soupPrice.Visible = true;

		specialName.Visible = false;
		special.Visible = false;
		specialPrice.Visible = false;

		fishName.Visible = false;
		fish.Visible = false;
		fishPrice.Visible = false;

	}

	protected void OnChefButtonClicked(object sender, EventArgs e)
	{
		specialName.Visible = true;
		special.Visible = true;
		specialPrice.Visible = true;

		soupName.Visible = false;
		soup.Visible = false;
		soupPrice.Visible = false;

		fishName.Visible = false;
		fish.Visible = false;
		fishPrice.Visible = false;

	}

	protected void OnFishButtonClicked(object sender, EventArgs e)
	{
		fishName.Visible = true;
		fish.Visible = true;
		fishPrice.Visible = true;

		soupName.Visible = false;
		soup.Visible = false;
		soupPrice.Visible = false;

		specialName.Visible = false;
		special.Visible = false;
		specialPrice.Visible = false;
	}
}
