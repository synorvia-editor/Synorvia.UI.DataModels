using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Synorvia.UI.DataModels.TabControl
{
    public interface ITabControl
    {
        ObservableCollection<ITabPage> Pages { get; set; }

        bool CanClose { get; set; }
    
        ITabPage ActivePage { get; set; }

        bool ShowTabsOnBottom { get; set; }
    }
}
