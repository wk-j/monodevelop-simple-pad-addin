using System;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui.Components;
using MonoDevelop.Ide.Gui.Pads;
using MonoDevelop.Projects;

namespace MonoDevelopSimplePadAddin {
	public class SimpleTreeViewPad: TreeViewPad {
		public SimpleTreeViewPad() {
		}

		public override void Initialize(NodeBuilder[] builders, TreePadOption[] options, string menuPath) {
			base.Initialize(builders, options, menuPath);

			//foreach (WorkspaceItem it in IdeApp.Workspace.Items)
			var it = new TreeViewItem("Hello", Gtk.Stock.New);
				treeView.AddChild(it);

		}
		protected virtual void OnOpenWorkspace(object sender, WorkspaceItemEventArgs e) {
			//treeView.AddChild(e.Item);
		}

		protected virtual void OnCloseWorkspace(object sender, WorkspaceItemEventArgs e) {
			//treeView.RemoveChild(e.Item);
		}
	}
}
