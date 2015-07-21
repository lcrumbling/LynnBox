using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{
    public class AddressGroup : ObservableObject
    {
        public AddressGroup()
        {
            this.Addresses = new ObservableCollection<Address>();
            Address ad1 = new Address();
            ad1.StreetNum = "312";
            ad1.StreetName = "Maxson";
            this.Addresses.Add(ad1);
            Address ad2 = new Address();
            ad2.StreetNum = "549";
            ad2.StreetName = "Hillcrest";
            this.Addresses.Add(ad2);
            Address ad3 = new Address();
            ad3.StreetNum = "100";
            ad3.StreetName = "Spooky Nook";
            this.Addresses.Add(ad3);
        }

        public AddressGroup(Guid guidAddressGroup) : this()
        {
        }

        private Guid _addressGroupID = Guid.Empty;
        public Guid AddressGroupID
        {
            get { return this._addressGroupID; }
            set { this.Set(ref this._addressGroupID, value); }
        }

        private string _name = string.Empty;
        public string Name
        {
            get { return this._name; }
            set { this.Set(ref _name, value); }
        }

        private ObservableCollection<Address> _addresses;
        public ObservableCollection<Address> Addresses
        {
            get { return this._addresses; }
            set { this.Set(ref this._addresses, value); }
        }

    }
}
