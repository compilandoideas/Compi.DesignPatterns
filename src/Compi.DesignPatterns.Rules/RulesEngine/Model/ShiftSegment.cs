using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi.DesignPatterns.RulesEngine.Model
{
    public enum ShiftSegment
    {
        None = 0,
        EntryToShift = 1,
        EntryToLunch = 2,
        EndOfLunchTime = 3,
        DepartureFromShift = 4
    }
}
