using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FluCreate.viewModel
{
    class TaskViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string startTime;
        private string cron;
        private bool mzhzy;
        private bool cyxj;
        private bool swjl;
        private bool cylgba;
        private bool jyjl;
        private bool yyjl;


        public bool Swjl
        {
            get { return swjl; }
            set
            {
                swjl = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("swjl"));
                }
            }
        }

        public bool Cyxj
        {
            get { return cyxj; }
            set
            {
                cyxj = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("cyxj"));
                }
            }
        }

        public bool Cylgba
        {
            get { return cylgba; }
            set
            {
                cylgba = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("cylgba"));
                }
            }
        }

        public bool Jyjl
        {
            get { return jyjl; }
            set
            {
                jyjl = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("jyjl"));
                }
            }
        }

        public bool Yyjl
        {
            get { return yyjl; }
            set
            {
                yyjl = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("yyjl"));
                }
            }
        }


        public bool Mzhzy
        {
            get { return mzhzy; }
            set
            {
                mzhzy = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("mzhzy"));
                }
            }
        }

        public string Cron
        {
            get { return cron; }
            set
            {
                cron = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("cron"));
                }
            }
        }
        public string StartTime
        {
            get { return DateTime.Parse(startTime).ToString("yyyy-MM-dd"); }
            set
            {
                startTime = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("startTime"));
                }
            }
        }
    }
}
