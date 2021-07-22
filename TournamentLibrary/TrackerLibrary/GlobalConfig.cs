using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    static class GlobalConfig
    {
        public static List<IDataConnections> Connections { get; private set; }

        public static void InitializeConnection(bool database, bool textFiles)
        {
            if (database) {

            }

            if (textFiles)
            {

            }
        }
    }
}
