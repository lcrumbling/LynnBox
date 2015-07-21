using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{
    public class Unit : ObservableObject
    {
        public Unit()
        { 
        }

        public Unit(Guid guidUnit)
        {
        }

        private Guid _unitID = Guid.Empty;
        public Guid UnitID
        {
            get { return this._unitID; }
            set { this.Set(ref this._unitID, value); }
        }

        private string _unitName = string.Empty;
        public string UnitName
        {
            get { return this._unitName; }
            set { this.Set(ref _unitName, value); }
        }
    }
}
