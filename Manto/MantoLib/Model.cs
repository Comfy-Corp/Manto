using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantoLib
{
    public class FortuneInformation : INotifyPropertyChanged
    {
        //Notify property changed requirement
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                handler(this, args);
            }
        }

        private string name;
        private bool isFamily;
        private FortuneTargetType targetType;
        
        public string Name{
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public bool IsFamily
        {
            get
            {
                return isFamily;
            }
            set
            {
                isFamily = value;
                NotifyPropertyChanged("IsFamily");
            }
        }
        public FortuneTargetType TargetType
        {
            get
            {
                return targetType;
            }
            set
            {
                targetType = value;
                NotifyPropertyChanged("TargetType");
            }
        }
    }

    public enum FortuneTargetType
    {
        PERSON_FORTUNE,
        LOCATION_FORTUNE,
        PET_FORTUNE
    }
}
