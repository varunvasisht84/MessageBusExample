using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBusPatternInWPF
{
    public class MessageBusManager
    {
        #region Fields

        public MessageBus Bus;

        private static volatile MessageBusManager instance;
        private static object syncRoot = new Object();

        #endregion Fields

        #region Constructors

        private MessageBusManager()
        {
            Bus = new MessageBus();
        }

        #endregion Constructors

        #region Properties

        public static MessageBusManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new MessageBusManager();
                    }
                }

                return instance;
            }
        }

        #endregion Properties
    }   
}
