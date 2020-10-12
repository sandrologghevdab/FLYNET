using System;
using System.Collections.Generic;
using System.Text;

namespace FLYNET
{
    interface IKost
    {
        Decimal BasisKostprijsPerDag { get; set; }
        public Decimal BerekenTotaleKostprijsPerDag();
    }
}
