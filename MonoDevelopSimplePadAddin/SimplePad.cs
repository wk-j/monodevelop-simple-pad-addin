
using System;
using MonoDevelop.Components;
using MonoDevelop.Ide.Gui;

namespace MonoDevelopSimplePadAddin
{
	public class SimplePad : PadContent 
	{
		Gtk.Label label;

		public new void Initialize (IPadWindow window)
		{
			label = new Gtk.Label ("Simple pad label");
			label.Visible = true;
		}

		public void RedrawContent ()
		{
		}

		public override Control Control {
			get { return label; }
		}

		public override void Dispose ()
		{

		}
	}
}

