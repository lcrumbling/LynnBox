using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{
    public class Address : ObservableObject
    {
        public Address()
        {
            this.Units = new ObservableCollection<Unit>();
            Unit u1 = new Unit();
            u1.UnitName = "u1";
            this.Units.Add(u1);
            Unit u2= new Unit();
            u2.UnitName = "u2";
            this.Units.Add(u2);
        }

        public Address(Guid guidAddress) : this()
        {
        }

        private Guid _addressID = Guid.Empty;
        public Guid AddressID
        {
            get { return this._addressID; }
            set { this.Set(ref this._addressID, value); }
        }

        private string _streetNum = string.Empty;
        public string StreetNum
        {
            get { return this._streetNum; }
            set { this.Set(ref _streetNum, value); RaisePropertyChanged("FullAddress"); }
        }

        private string _streetName = string.Empty;
        public string StreetName
        {
            get { return this._streetName; }
            set { this.Set(ref _streetName, value); RaisePropertyChanged("FullAddress"); }
        }

        public string FullAddress
        {
            get { return this.StreetNum + " " + this.StreetName; }
        }

        private ObservableCollection<Unit> _units;
        public ObservableCollection<Unit> Units
        {
            get { return this._units; }
            set { this.Set(ref this._units, value); }
        }

    }
}
