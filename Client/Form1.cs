using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using AppModule.InterProcessComm;
using AppModule.NamedPipes;

namespace Client {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox Activity;
		private System.Windows.Forms.Label duration;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Activity = new System.Windows.Forms.TextBox();
			this.duration = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 48);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 56);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// Activity
			// 
			this.Activity.Location = new System.Drawing.Point(8, 80);
			this.Activity.Multiline = true;
			this.Activity.Name = "Activity";
			this.Activity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Activity.Size = new System.Drawing.Size(272, 184);
			this.Activity.TabIndex = 2;
			this.Activity.Text = "";
			// 
			// duration
			// 
			this.duration.Location = new System.Drawing.Point(208, 16);
			this.duration.Name = "duration";
			this.duration.Size = new System.Drawing.Size(64, 23);
			this.duration.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.duration);
			this.Controls.Add(this.Activity);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e) {
			if (textBox1.Text != "") {
				DateTime dt = DateTime.Now;
				// This cycle is used only when you want to run numerous name pipes requests 
				// and measure the performance. In the general case it is not needed.
				for (int i = 0; i < 1; i++) {
					IInterProcessConnection clientConnection = null;
					try {
						clientConnection = new ClientPipeConnection("MyPipe", ".");
						clientConnection.Connect();
						clientConnection.Write(textBox1.Text);
						Activity.AppendText(clientConnection.Read() + Environment.NewLine);
						clientConnection.Close();
					}
					catch (Exception ex) {
						clientConnection.Dispose();
						throw (ex);
					}
				}
				this.duration.Text = DateTime.Now.Subtract(dt).Milliseconds.ToString();
			}
		}
	}
}
