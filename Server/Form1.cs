using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using AppModule.InterProcessComm;
using AppModule.NamedPipes;

namespace Server
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox Activity;
		public static System.Windows.Forms.TextBox ActivityRef;

		public static IChannelManager PipeManager;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ActivityRef = this.Activity;
			PipeManager = new PipeManager();
			PipeManager.Initialize();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Activity = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Activity
			// 
			this.Activity.Location = new System.Drawing.Point(16, 16);
			this.Activity.Multiline = true;
			this.Activity.Name = "Activity";
			this.Activity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Activity.Size = new System.Drawing.Size(256, 240);
			this.Activity.TabIndex = 0;
			this.Activity.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.Activity);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			if (PipeManager != null) {
				PipeManager.Stop();
			}
		}
	}
}
