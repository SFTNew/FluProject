
using System.ComponentModel;

namespace FluCreate.viewModel
{
   public  class DateBaseViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string dataBaseUrl;
        private string dataBaseUser;
        private string dataBasePassword;
        private string dataBaseCatalog;
        public string DataBaseUrl
        {
            get { return dataBaseUrl; }
            set
            {
                dataBaseUrl = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DataBaseUrl"));
                }
            }
        }
        public string DataBaseUser
        {
            get { return dataBaseUser; }
            set
            {
                dataBaseUser = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DataBaseUser"));
                }
            }
        }
        public string DataBasePassword
        {
            get { return dataBasePassword; }
            set
            {
                dataBasePassword = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DataBasePassword"));
                }
            }
        }

        public string DataBaseCatalog
        {
            get { return dataBaseCatalog; }
            set
            {
              
                    dataBaseCatalog = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DataBaseCatalog"));
                }
            }
        }





    }
}
