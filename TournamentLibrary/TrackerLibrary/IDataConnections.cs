using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public interface IDataConnections
    {
        public PrizeModel CreatePrize(PrizeModel model);
    }
}
