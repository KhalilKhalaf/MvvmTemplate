using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmTemplate.ViewModels
{
    public class MainViewModel : Screen
    {
        private string _firstName = "First";
        private string _lastName = "Last";

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName); // this notifies the change to whoever binded to FirstName property
                NotifyOfPropertyChange(() => FullName); // this notifies the change to whoever binded to FullName property
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName); // this notifies the change to whoever binded to LastName property
                NotifyOfPropertyChange(() => FullName); // this notifies the change to whoever binded to FullName property
            }
        }
        public string FullName
        {
            get
            {
                return $" { FirstName } { LastName } ";
            }

        }
    }
}
