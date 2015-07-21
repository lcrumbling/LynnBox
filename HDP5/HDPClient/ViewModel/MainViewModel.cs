using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using HDPClientObjLib;

namespace HDPClient.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            this.AddressGroups = new ObservableCollection<AddressGroup>();
            AddressGroup ag1 = new AddressGroup();
            ag1.Name = "Addresses";
            ag1.AddressGroupID = Guid.NewGuid();
            this.AddressGroups.Add(ag1);
            AddressGroup ag2 = new AddressGroup();
            ag2.Name = "Completed Addresses";
            ag2.AddressGroupID = Guid.NewGuid();
            this.AddressGroups.Add(ag2);
            AddressGroup ag3 = new AddressGroup();
            ag3.Name = "Incomplete Addresses";
            ag3.AddressGroupID = Guid.NewGuid();
            this.AddressGroups.Add(ag3);

            this.TradeList = new HDPClientObjLib.TradeList();
            Tabs = new ObservableCollection<object>();

        }

        private TradeList _tradeList;
        public TradeList TradeList
        {
            get { return this._tradeList; }
            set { this.Set(ref this._tradeList, value); }
        }

        private ObservableCollection<AddressGroup> _addressGroups;
        public ObservableCollection<AddressGroup> AddressGroups
        {
            get { return this._addressGroups; }
            set { this.Set(ref this._addressGroups, value); }
        }



        private object _selectedTab;
        public object SelectedTab
        {
            get { return this._selectedTab; }
            set { this.Set(ref this._selectedTab, value); }
        }

        private ObservableCollection<object> _tabs;
        public ObservableCollection<object> Tabs
        {
            get { return this._tabs; }
            set { this.Set(ref this._tabs, value); }
        }

        RelayCommand _showSpecLibraryCommand;
        public RelayCommand ShowSpecLibraryCommand
        {
            get
            {
                if (_showSpecLibraryCommand == null)
                    _showSpecLibraryCommand = new RelayCommand(this.ShowSpecLibrary);
                return _showSpecLibraryCommand;
            }
        }

        RelayCommand _showTradeEditorCommand;
        public RelayCommand ShowTradeEditorCommand
        {
            get
            {
                if (_showTradeEditorCommand == null)
                    _showTradeEditorCommand = new RelayCommand(this.ShowTradeEditor);
                return _showTradeEditorCommand;
            }
        }

        RelayCommand<Specification> _editSpecCommand;
        public RelayCommand<Specification> EditSpecCommand
        {
            get
            {
                if (_editSpecCommand == null)
                    _editSpecCommand = new RelayCommand<Specification>(this.EditSpec);
                return _editSpecCommand;
            }
        }

        public void ShowTradeEditor()
        {
            this.Tabs.Add(TradeList);
            this.SelectedTab = TradeList;
        }
    

        public void ShowSpecLibrary()
        {
            SpecLibrary s = new SpecLibrary();
            this.Tabs.Add(s);
            this.SelectedTab = s;
        }

        public void EditSpec(Specification sRequested)
        {            
            bool fAlreadyOpen = false;
            foreach (var tab in this.Tabs)
            {
                if (tab.GetType() == typeof(Specification))
                {
                    Specification s = tab as Specification;
                    if (s == sRequested)
                    {
                        fAlreadyOpen = true;
                        this.SelectedTab = s;
                        break;
                    }
                }
            }

            if (!fAlreadyOpen)
            {
                this.Tabs.Add(sRequested);
                this.SelectedTab = sRequested;
            }

        }


    }
}