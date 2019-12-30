using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluCreate.viewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string hqmsPath;
        private string fluPath;
        private string backUpPath;
        private string startTime;
        private string endTime;


        public string EndTime
        {
            get
            {
                return DateTime.Parse(endTime).ToString("yyyy-MM-dd");
            }
            set
            {
                endTime = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("endTime"));
                }
            }
        }


        public string StartTime
        {
            get
            {
                return DateTime.Parse(startTime).ToString("yyyy-MM-dd");
            }
            set
            {
                startTime = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("backUpPath"));
                }
            }
        }

        public string BackUpPath
        {
            get { return backUpPath; }
            set
            {
                backUpPath = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("backUpPath"));
                }
            }
        }


        public string HqmsPath {
            get { return hqmsPath; }
            set {
                hqmsPath = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("hqmsPath"));
                }
            }
        }

        public string FluPath
        {
            get
            {
                return fluPath;
            }
            set
            {
                fluPath = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("fluPath"));
                }
            }
        }
        
    }
}
