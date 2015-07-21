using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace HDPClientObjLib
{
    public class TradeList : ObservableObject
    {
        public TradeList()
        {
            this.AllTrades = new ObservableCollection<Trade>();
            Trade tr1 = new Trade();
            tr1.TradeDescription = "Plumbing";
            tr1.TradeNumber = 1;
            tr1.DateModified = new DateTime(2010, 2, 9);
            this.AllTrades.Add(tr1);
            Trade tr2 = new Trade();
            tr2.TradeDescription = "Electrical";
            tr2.TradeNumber = 2;
            tr2.DateModified = new DateTime(2014, 5, 16);
            this.AllTrades.Add(tr2);
        }

        private ObservableCollection<Trade> _allTrades;
        public ObservableCollection<Trade> AllTrades
        {
            get { return this._allTrades; }
            set { this.Set(ref this._allTrades, value); }
        }
    }
}
