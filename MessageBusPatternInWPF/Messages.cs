using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBusPatternInWPF
{
    public class TMessage
    {
        public List<object> Payload;
    }

    public class ChangeTabTextMessage : TMessage
    {
    }

    public class ChangeTabTextMessageWithParameter : TMessage
    {
        #region Fields

        public string Text;

        #endregion Fields

        #region Constructors

        public ChangeTabTextMessageWithParameter(string text)
        {
            Text = text;
        }

        #endregion Constructors
    }
}
