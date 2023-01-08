using System.Collections.Generic;
using System.Linq;

namespace Memento.Models
{
    // The Caretaker doesn't depend on the Memento class. Therefore, it
    // doesn't have access to the originator's state, stored inside the memento.
    // It works with all mementos via the base Memento interface or class.
    public class History
    {
        private readonly List<CheckPoint> _checks = new List<CheckPoint>();

        public void AddCheckPoint(CheckPoint checkPoint)
        {
            _checks.Add(checkPoint);
        }

        public CheckPoint Restore()
        {
            var lastCheckpoint = _checks.LastOrDefault();
            //Here You Can Remove This Memento or Keep it to Implement Redo
            return lastCheckpoint;
        }
    }
}
