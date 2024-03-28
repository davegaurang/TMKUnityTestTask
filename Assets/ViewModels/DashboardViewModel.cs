using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboards.Assets.ViewModels
{
    public class DashboardViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _isDashboard = true;

        public bool IsDashboard
        {
            get { return _isDashboard; }
            set 
            { 
                _isDashboard = value; 
                OnPropertyChanged(nameof(IsDashboard));
                if (_isDashboard)
                {
                    IsHowItWorks = false;
                    IsResources = false;
                    IsWorkout = false;
                    IsLeaderBoard = false;
                    IsSetting = false;
                    IsTrainings = false;
                }
            }
        }


        private bool _isHowItWorks = false;

        public bool IsHowItWorks
        {
            get { return _isHowItWorks; }
            set
            {
                _isHowItWorks = value;
                OnPropertyChanged(nameof(IsHowItWorks));
                if (value)
                {
                    IsDashboard = false;
                    IsResources = false;
                    IsWorkout = false;
                    IsLeaderBoard = false;
                    IsSetting = false;
                    IsTrainings = false;
                }
            }
        }

        private bool _isResources = false;

        public bool IsResources
        {
            get { return _isResources; }
            set
            {
                _isResources = value;
                OnPropertyChanged(nameof(IsResources));
                if (value)
                {
                    IsDashboard = false;
                    IsHowItWorks = false;
                    IsWorkout = false;
                    IsLeaderBoard = false;
                    IsSetting = false;
                    IsTrainings = false;
                }
            }
        }

        private bool _isWorkout = false;

        public bool IsWorkout
        {
            get { return _isWorkout; }
            set
            {
                _isWorkout = value;
                OnPropertyChanged(nameof(IsWorkout));
                if (value)
                {
                    IsDashboard = false;
                    IsHowItWorks = false;
                    IsResources = false;
                    IsLeaderBoard = false;
                    IsSetting = false;
                    IsTrainings = false;
                }
            }
        }

        private bool _isTrainings = false;

        public bool IsTrainings
        {
            get { return _isTrainings; }
            set
            {
                _isTrainings = value;
                OnPropertyChanged(nameof(IsTrainings));
                if (value)
                {
                    IsDashboard = false;
                    IsHowItWorks = false;

                    IsWorkout = false;
                    IsLeaderBoard = false;
                    IsSetting = false;

                }
            }
        }

        private bool _isLeaderBoard = false;

        public bool IsLeaderBoard
        {
            get { return _isLeaderBoard; }
            set
            {
                _isLeaderBoard = value;
                OnPropertyChanged(nameof(IsLeaderBoard));
                if (value)
                {
                    IsDashboard = false;
                    IsHowItWorks = false;
                    IsResources = false;
                    IsWorkout = false;
                    IsTrainings = false;
                    IsSetting = false;
                }
            }
        }

        private bool _isSetting = false;

        public bool IsSetting
        {
            get { return _isSetting; }
            set
            {
                _isSetting = value;
                OnPropertyChanged(nameof(IsSetting));
                if (value)
                {
                    IsDashboard = false;
                    IsHowItWorks = false;
                    IsResources = false;
                    IsWorkout = false;
                    IsTrainings = false;
                    IsLeaderBoard = false;
                }
            }
        }
      

        public DashboardViewModel()
        {
                
        }
    }
}
