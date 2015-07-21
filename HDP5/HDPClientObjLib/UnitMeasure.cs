using System;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{
    public class UnitMeasure : ObservableObject
    {
        private Guid _unitMeasureID;
        public Guid UnitMeasureID
        {
            get { return _unitMeasureID; }
            set { this.Set(ref this._unitMeasureID, value); }
        }

        private string _unitMeasureAbbr;
        public string UnitMeasureAbbr
        {
            get { return _unitMeasureAbbr; }
            set { this.Set(ref this._unitMeasureAbbr, value); }
        }

        private string _unitMeasureDesc;
        public string UnitMeasureDesc
        {
            get { return _unitMeasureDesc; }
            set { this.Set(ref this._unitMeasureDesc, value); }
        }

        private int _sortOrder;
        public int SortOrder
        {
            get { return _sortOrder; }
            set { this.Set(ref this._sortOrder, value); }
        }
    }
}
