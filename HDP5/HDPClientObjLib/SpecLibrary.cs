using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{
    public class SpecLibrary : ObservableObject
    {
        public SpecLibrary()
        {
            this.Specs = new ObservableCollection<Specification>();
            Specification sp1 = new Specification();
            sp1.SpecNumber = "1234";
            sp1.SpecTitle = "Test Spec1";
            this.Specs.Add(sp1);
            Specification sp2 = new Specification();
            sp2.SpecNumber = "5454";
            sp2.SpecTitle = "Another Specs";
            this.Specs.Add(sp2);
        }

        private ObservableCollection<Specification> _specs;
        public ObservableCollection<Specification> Specs
        {
            get { return this._specs; }
            set { this.Set(ref this._specs, value); }
        }
    }
}

