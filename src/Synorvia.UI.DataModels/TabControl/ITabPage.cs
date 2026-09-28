using System;
using System.Collections.Generic;
using System.Text;

namespace Synorvia.UI.DataModels.TabControl
{
    public interface ITabPage
    {
        Type ViewType { get; }

        string Header { get; }

        
    }
}
