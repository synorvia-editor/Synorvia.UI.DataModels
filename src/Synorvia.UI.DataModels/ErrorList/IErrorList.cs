using System.Collections.Generic;

namespace Synorvia.UI.DataModels.ErrorList
{
    public interface IErrorList
    {
        List<IErrorListElement> Errors { get; set; }

        bool ShowErrorCode { get; set; }

    }
}
