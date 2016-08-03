using System;
using MonoDevelop.Ide.Gui.Components;
using MonoDevelop.Ide.Gui.Pads;

namespace MonoDevelopSimplePadAddin {
	public class SimpleTreeViewPad: TreeViewPad {
		public SimpleTreeViewPad() {
		}

		public override void Initialize(NodeBuilder[] builders, TreePadOption[] options, string menuPath) {
			base.Initialize(builders, options, menuPath);


			TreeView.AddChild("Hello word");
			TreeView.AddChild("Hello word");
			TreeView.AddChild("Hello word");
		}

	}
}
