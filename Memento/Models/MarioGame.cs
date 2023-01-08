namespace Memento.Models
{
    // The Originator holds some important state that may change over time. It
    // also defines a method for saving the state inside a memento and another
    // method for restoring the state from it.
    public class MarioGame
    {
        private readonly History _history;

        public MarioGame(History history)
        {
            _history = history;
        }

        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        public Level CurrentLevel { get; set; }

        // Saves the current state inside a memento.
        public void Save()
        {
            _history.AddCheckPoint(new CheckPoint(CurrentLevel));
        }

        // Restores the Originator's state from a memento object.
        public void Restore(CheckPoint checkPoint)
        {
            CurrentLevel = checkPoint.GetLevel();
        }

        // Restores the Originator's state from a memento object.
        public void Restore()
        {
            var restore = _history.Restore();
            CurrentLevel = restore.GetLevel();
        }
    }
}
