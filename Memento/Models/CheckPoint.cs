namespace Memento.Models
{
    // Memento contains the infrastructure for storing the
    // Originator's state.
    // you can create base memento interface or class which concrete mementos inherit or implement that base  
    // by using base class or interface you can have many concrete mementos. CareTaker(History) will works with this base class or interface
    // I didn't do this because it's a simple sample of memento
    public class CheckPoint
    {
        private readonly Level _level;

        public CheckPoint(Level level)
        {
            _level = level;
        }

        // The Originator uses this method when restoring its state.  
        public Level GetLevel()
        {
            return _level;
        }
    }
}
