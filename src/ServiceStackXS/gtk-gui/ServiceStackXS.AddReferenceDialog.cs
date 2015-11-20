
// This file has been generated by the GUI designer. Do not modify.
namespace ServiceStackXS
{
	public partial class AddReferenceDialog
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.TextView instructionsTextView;
		
		private global::Gtk.Label addressLabel;
		
		private global::Gtk.Entry addressEntry;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Entry nameEntry;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.TextView errorMessageView;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ServiceStackXS.AddReferenceDialog
			this.Name = "ServiceStackXS.AddReferenceDialog";
			this.Title = "Add ServiceStack Reference";
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("ServiceStackXS.favicon.ico");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Modal = true;
			this.DefaultWidth = 620;
			this.DefaultHeight = 320;
			// Internal child ServiceStackXS.AddReferenceDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(6));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 10;
			this.vbox3.BorderWidth = ((uint)(20));
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.instructionsTextView = new global::Gtk.TextView ();
			this.instructionsTextView.Buffer.Text = "\r\nTo generate the DTO Service Model types for a specific ServiceStack instance, e" +
			"nter the base URI for the remote ServiceStack server and click OK.";
			this.instructionsTextView.Sensitive = false;
			this.instructionsTextView.Name = "instructionsTextView";
			this.instructionsTextView.Editable = false;
			this.instructionsTextView.CursorVisible = false;
			this.instructionsTextView.AcceptsTab = false;
			this.instructionsTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.vbox2.Add (this.instructionsTextView);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.instructionsTextView]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.addressLabel = new global::Gtk.Label ();
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Xalign = 0.01F;
			this.addressLabel.LabelProp = "Address";
			this.addressLabel.SingleLineMode = true;
			this.vbox2.Add (this.addressLabel);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.addressLabel]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.addressEntry = new global::Gtk.Entry ();
			this.addressEntry.CanFocus = true;
			this.addressEntry.Name = "addressEntry";
			this.addressEntry.IsEditable = true;
			this.addressEntry.InvisibleChar = '●';
			this.vbox2.Add (this.addressEntry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.addressEntry]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox3.Add (this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox2]));
			w5.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 2;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0.01F;
			this.label2.LabelProp = "Name";
			this.vbox4.Add (this.label2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.nameEntry = new global::Gtk.Entry ();
			this.nameEntry.CanFocus = true;
			this.nameEntry.Name = "nameEntry";
			this.nameEntry.IsEditable = true;
			this.nameEntry.InvisibleChar = '●';
			this.vbox4.Add (this.nameEntry);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.nameEntry]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.errorMessageView = new global::Gtk.TextView ();
			this.errorMessageView.Sensitive = false;
			this.errorMessageView.CanFocus = true;
			this.errorMessageView.Name = "errorMessageView";
			this.errorMessageView.Editable = false;
			this.vbox5.Add (this.errorMessageView);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.errorMessageView]));
			w9.Position = 0;
			this.vbox3.Add (this.vbox5);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox5]));
			w10.Position = 2;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w11.Position = 0;
			// Internal child ServiceStackXS.AddReferenceDialog.ActionArea
			global::Gtk.HButtonBox w12 = this.ActionArea;
			w12.Name = "dialog1_ActionArea";
			w12.Spacing = 10;
			w12.BorderWidth = ((uint)(5));
			w12.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonCancel]));
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "OK";
			w12.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w12 [this.buttonOk]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.errorMessageView.Hide ();
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.CancelAdd);
			this.buttonOk.Clicked += new global::System.EventHandler (this.AddReference);
		}
	}
}
