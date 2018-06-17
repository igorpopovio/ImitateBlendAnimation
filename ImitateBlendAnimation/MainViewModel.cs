using System.Collections.ObjectModel;

namespace ImitateBlendAnimation
{
    public class MainViewModel : ViewModel
    {
        public ObservableCollection<WorkSet> Sets { get; set; }

        public MainViewModel()
        {
            Sets = new ObservableCollection<WorkSet>()
            {
                new WorkSet { Mass = 155, Reps = 10 },
                new WorkSet { Mass = 150, Reps = 11 },
                new WorkSet { Mass = 145, Reps = 12 },
                new WorkSet { Mass = 135, Reps = 14 },
            };
        }
    }
}
