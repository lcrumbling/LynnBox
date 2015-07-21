using System;
using System.ComponentModel;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{   
    public enum CostMethods
    {
        [Description("Contracted Cost")]
        ContractedCost,
        [Description("In House Cost")]
        InHouseCost,
        [Description("No Cost Associated")]
        NoCost,
    }

    public class Specification : ObservableObject
    {
        public Specification()
        {


        }
        public Specification(Guid SpecID)
        {


        }

        private Guid _specID;
        public Guid SpecID
        {
            get { return _specID; }
            set { this.Set(ref this._specID, value); }
        }

        private string _specNumber;
        public string SpecNumber
        {
            get { return _specNumber; }
            set { this.Set(ref this._specNumber, value); }
        }

        private string _specTitle;
        public string SpecTitle
        {
            get { return _specTitle; }
            set { this.Set(ref this._specTitle, value); }
        }

        private string _specText;
        public string SpecText
        {
            get { return _specText; }
            set { this.Set(ref this._specText, value); }
        }

        private Trade _trade;
        public Trade Trade
        {
            get { return _trade; }
            set { this.Set(ref this._trade, value); }
        }

        private UnitMeasure _unitMeasure;
        public UnitMeasure UnitMeasure
        {
            get { return _unitMeasure; }
            set { this.Set(ref this._unitMeasure, value); }
        }

        private CostMethods _costMethod = CostMethods.ContractedCost;
        public CostMethods CostMethod
        {
            get { return _costMethod; }
            set { this.Set(ref this._costMethod, value); }
        }

        private decimal _contractedCost = 0;
        public decimal ContractedCost
        {
            get { return _contractedCost; }
            set { this.Set(ref this._contractedCost, value); }
        }

        private decimal _inHouseLabor = 0;
        public decimal InHouseLabor
        {
            get { return _inHouseLabor; }
            set { this.Set(ref this._inHouseLabor, value); }
        }

        private decimal _inHouseMaterial = 0;
        public decimal InHouseMaterial
        {
            get { return _inHouseMaterial; }
            set { this.Set(ref this._inHouseMaterial, value); }
        }

        private decimal _flatFee = 0;
        public decimal FlatFee
        {
            get { return _flatFee; }
            set { this.Set(ref this._flatFee, value); }
        }

        private decimal _overhead = 0;
        public decimal Overhead
        {
            get { return _overhead; }
            set { this.Set(ref this._overhead, value); }
        }

        private decimal _overheadPercent = 0;
        public decimal OverheadPercent
        {
            get { return _overheadPercent; }
            set { this.Set(ref this._overheadPercent, value); }
        }

        private decimal _profit = 0;
        public decimal Profit
        {
            get { return _profit; }
            set { this.Set(ref this._profit, value); }
        } 

        private decimal _profitPercent = 0;
        public decimal ProfitPercent
        {
            get { return _profitPercent; }
            set { this.Set(ref this._profitPercent, value); }
        }

        private decimal _totalUnitCost = 0;
        public decimal TotalUnitCost
        {
            get { return _totalUnitCost; }
            set { this.Set(ref this._totalUnitCost, value); }
        }

        private DateTime? _dateModified;
        public DateTime? DateModified
        {
            get { return _dateModified; }
            set { this.Set(ref this._dateModified, value); }
        }

        private bool _ignoreSpecCostUpdates = false;
        public bool IgnoreSpecCostUpdates
        {
            get { return _ignoreSpecCostUpdates; }
            set { this.Set(ref this._ignoreSpecCostUpdates, value); }
        }

    }
}
