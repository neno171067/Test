
using System;

namespace MonoTest
{
	
	
	public partial class MainWindow : Gtk.Dialog
	{

		protected virtual void OnCancelClick (object sender, System.EventArgs e)
				{
				System.Environment.Exit(0);
		}
		
		
		public MainWindow()
		{
			this.Build();
			label2.Text ="";
		}

		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		
			
		{
			label2.Text ="it's working ...";
		
		}
		
		
	}
}
