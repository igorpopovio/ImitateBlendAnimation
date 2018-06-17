namespace ImitateBlendAnimation
{
    public class WorkSet : ViewModel
    {
        private int mass;
        public int Mass
        {
            get { return mass; }
            set
            {
                mass = value;
                OnPropertyChanged();
            }
        }

        private int reps;
        public int Reps
        {
            get { return reps; }
            set
            {
                reps = value;
                OnPropertyChanged();
            }
        }

        private bool isComplete;
        public bool IsComplete
        {
            get { return isComplete; }
            set
            {
                isComplete = value;
                OnPropertyChanged();
            }
        }
    }
}
