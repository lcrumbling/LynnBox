using System;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{
    public class Trade : ObservableObject
    {
        private Guid _tradeID;
        public Guid TradeID
        {
            get { return _tradeID; }
            set { this.Set(ref this._tradeID, value); }
        }

        private int _tradeNumber;
        public int TradeNumber
        {
            get { return _tradeNumber; }
            set { this.Set(ref this._tradeNumber, value); }
        }

        private string _tradeDescription;
        public string TradeDescription
        {
            get { return _tradeDescription; }
            set { this.Set(ref this._tradeDescription, value); }
        }
        private DateTime? _dateModified;
        public DateTime? DateModified
        {
            get { return _dateModified; }
            set { this.Set(ref this._dateModified, value); }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set { this.Set(ref this._note, value); }
        }
    }
}
