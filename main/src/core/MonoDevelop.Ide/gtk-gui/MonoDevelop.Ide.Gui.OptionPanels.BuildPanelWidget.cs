
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Gui.OptionPanels
{
	partial class BuildPanelWidget
	{
		private global::Gtk.VBox vbox66;

		private global::Gtk.CheckButton buildBeforeRunCheckBox;

		private global::Gtk.CheckButton runWithWarningsCheckBox;

		private global::Gtk.CheckButton parallelBuildCheckbox;

		private global::Gtk.CheckButton buildBeforeTestCheckBox;

		private global::Gtk.CheckButton buildWithMSBuildCheckBox;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::Gtk.ComboBox verbosityCombo;

		private global::Gtk.Label buildAndRunOptionsLabel;

		private global::Gtk.HBox hbox44;

		private global::Gtk.Label label71;

		private global::Gtk.VBox vbox67;

		private global::Gtk.RadioButton saveChangesRadioButton;

		private global::Gtk.RadioButton promptChangesRadioButton;

		private global::Gtk.RadioButton noSaveRadioButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Ide.Gui.OptionPanels.BuildPanelWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.Ide.Gui.OptionPanels.BuildPanelWidget";
			// Container child MonoDevelop.Ide.Gui.OptionPanels.BuildPanelWidget.Gtk.Container+ContainerChild
			this.vbox66 = new global::Gtk.VBox();
			this.vbox66.Name = "vbox66";
			this.vbox66.Spacing = 6;
			// Container child vbox66.Gtk.Box+BoxChild
			this.buildBeforeRunCheckBox = new global::Gtk.CheckButton();
			this.buildBeforeRunCheckBox.CanFocus = true;
			this.buildBeforeRunCheckBox.Name = "buildBeforeRunCheckBox";
			this.buildBeforeRunCheckBox.Label = global::Mono.Unix.Catalog.GetString("Build project before running");
			this.buildBeforeRunCheckBox.DrawIndicator = true;
			this.buildBeforeRunCheckBox.UseUnderline = true;
			this.vbox66.Add(this.buildBeforeRunCheckBox);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.buildBeforeRunCheckBox]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox66.Gtk.Box+BoxChild
			this.runWithWarningsCheckBox = new global::Gtk.CheckButton();
			this.runWithWarningsCheckBox.CanFocus = true;
			this.runWithWarningsCheckBox.Name = "runWithWarningsCheckBox";
			this.runWithWarningsCheckBox.Label = global::Mono.Unix.Catalog.GetString("Run project if build completed with warnings");
			this.runWithWarningsCheckBox.DrawIndicator = true;
			this.runWithWarningsCheckBox.UseUnderline = true;
			this.vbox66.Add(this.runWithWarningsCheckBox);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.runWithWarningsCheckBox]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox66.Gtk.Box+BoxChild
			this.parallelBuildCheckbox = new global::Gtk.CheckButton();
			this.parallelBuildCheckbox.CanFocus = true;
			this.parallelBuildCheckbox.Name = "parallelBuildCheckbox";
			this.parallelBuildCheckbox.Label = global::Mono.Unix.Catalog.GetString("Enable parallel build of projects");
			this.parallelBuildCheckbox.DrawIndicator = true;
			this.parallelBuildCheckbox.UseUnderline = true;
			this.vbox66.Add(this.parallelBuildCheckbox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.parallelBuildCheckbox]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox66.Gtk.Box+BoxChild
			this.buildBeforeTestCheckBox = new global::Gtk.CheckButton();
			this.buildBeforeTestCheckBox.CanFocus = true;
			this.buildBeforeTestCheckBox.Name = "buildBeforeTestCheckBox";
			this.buildBeforeTestCheckBox.Label = global::Mono.Unix.Catalog.GetString("Build project before executing unit tests");
			this.buildBeforeTestCheckBox.DrawIndicator = true;
			this.buildBeforeTestCheckBox.UseUnderline = true;
			this.vbox66.Add(this.buildBeforeTestCheckBox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.buildBeforeTestCheckBox]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox66.Gtk.Box+BoxChild
			this.buildWithMSBuildCheckBox = new global::Gtk.CheckButton();
			this.buildWithMSBuildCheckBox.CanFocus = true;
			this.buildWithMSBuildCheckBox.Name = "buildWithMSBuildCheckBox";
			this.buildWithMSBuildCheckBox.Label = global::Mono.Unix.Catalog.GetString("Build with MSBuild instead of xbuild");
			this.buildWithMSBuildCheckBox.DrawIndicator = true;
			this.buildWithMSBuildCheckBox.UseUnderline = true;
			this.vbox66.Add(this.buildWithMSBuildCheckBox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.buildWithMSBuildCheckBox]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox66.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(36));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Log _verbosity:");
			this.label1.UseUnderline = true;
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.verbosityCombo = global::Gtk.ComboBox.NewText();
			this.verbosityCombo.AppendText(global::Mono.Unix.Catalog.GetString("Quiet"));
			this.verbosityCombo.AppendText(global::Mono.Unix.Catalog.GetString("Minimal"));
			this.verbosityCombo.AppendText(global::Mono.Unix.Catalog.GetString("Normal"));
			this.verbosityCombo.AppendText(global::Mono.Unix.Catalog.GetString("Detailed"));
			this.verbosityCombo.AppendText(global::Mono.Unix.Catalog.GetString("Diagnostic"));
			this.verbosityCombo.Name = "verbosityCombo";
			this.verbosityCombo.Active = 2;
			this.hbox1.Add(this.verbosityCombo);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.verbosityCombo]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.alignment1.Add(this.hbox1);
			this.vbox66.Add(this.alignment1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.alignment1]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox66.Gtk.Box+BoxChild
			this.buildAndRunOptionsLabel = new global::Gtk.Label();
			this.buildAndRunOptionsLabel.Name = "buildAndRunOptionsLabel";
			this.buildAndRunOptionsLabel.Xalign = 0F;
			this.buildAndRunOptionsLabel.Yalign = 0F;
			this.buildAndRunOptionsLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>File Save Options Before Building</b>");
			this.buildAndRunOptionsLabel.UseMarkup = true;
			this.vbox66.Add(this.buildAndRunOptionsLabel);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.buildAndRunOptionsLabel]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			w10.Padding = ((uint)(6));
			// Container child vbox66.Gtk.Box+BoxChild
			this.hbox44 = new global::Gtk.HBox();
			this.hbox44.Name = "hbox44";
			this.hbox44.Spacing = 6;
			// Container child hbox44.Gtk.Box+BoxChild
			this.label71 = new global::Gtk.Label();
			this.label71.Name = "label71";
			this.label71.Xalign = 0F;
			this.label71.Yalign = 0F;
			this.label71.LabelProp = "    ";
			this.hbox44.Add(this.label71);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox44[this.label71]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox44.Gtk.Box+BoxChild
			this.vbox67 = new global::Gtk.VBox();
			this.vbox67.Name = "vbox67";
			this.vbox67.Spacing = 6;
			// Container child vbox67.Gtk.Box+BoxChild
			this.saveChangesRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("_Save changes to open documents"));
			this.saveChangesRadioButton.Name = "saveChangesRadioButton";
			this.saveChangesRadioButton.DrawIndicator = true;
			this.saveChangesRadioButton.UseUnderline = true;
			this.saveChangesRadioButton.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.vbox67.Add(this.saveChangesRadioButton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox67[this.saveChangesRadioButton]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox67.Gtk.Box+BoxChild
			this.promptChangesRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("_Prompt to save changes to open documents"));
			this.promptChangesRadioButton.Name = "promptChangesRadioButton";
			this.promptChangesRadioButton.DrawIndicator = true;
			this.promptChangesRadioButton.UseUnderline = true;
			this.promptChangesRadioButton.Group = this.saveChangesRadioButton.Group;
			this.vbox67.Add(this.promptChangesRadioButton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox67[this.promptChangesRadioButton]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox67.Gtk.Box+BoxChild
			this.noSaveRadioButton = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("_Don't save changes to open documents "));
			this.noSaveRadioButton.Name = "noSaveRadioButton";
			this.noSaveRadioButton.DrawIndicator = true;
			this.noSaveRadioButton.UseUnderline = true;
			this.noSaveRadioButton.Group = this.saveChangesRadioButton.Group;
			this.vbox67.Add(this.noSaveRadioButton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox67[this.noSaveRadioButton]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.hbox44.Add(this.vbox67);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox44[this.vbox67]));
			w15.Position = 1;
			w15.Expand = false;
			this.vbox66.Add(this.hbox44);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox66[this.hbox44]));
			w16.Position = 7;
			this.Add(this.vbox66);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
		}
	}
}
