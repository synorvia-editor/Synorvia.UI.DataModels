using System.Collections.ObjectModel;

namespace Synorvia.UI.DataModels.Tree
{
    public interface ITree
    {
        ObservableCollection<ITreeNode> TreeRootNodes { get; }

        ITreeNode SelectedNode { get; set; }
    }
}
