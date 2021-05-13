using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CustomFiltering_MVVM {
    public class MainViewModel : ViewModelBase {
        public bool HideEvenItems {
            get { return GetValue<bool>(nameof(HideEvenItems)); }
            set { SetValue(value, UpdateFiltrationLogic, nameof(HideEvenItems)); }
        }
        public bool HideOddItems {
            get { return GetValue<bool>(nameof(HideOddItems)); }
            set { SetValue(value, UpdateFiltrationLogic, nameof(HideOddItems)); }
        }
        public ICommand<RowFilterArgs> CustomRowFilterCommand {
            get { return GetValue<ICommand<RowFilterArgs>>(nameof(CustomRowFilterCommand)); }
            set { SetValue(value, nameof(CustomRowFilterCommand)); }
        }
        public ObservableCollection<object> Items { get; }
        public MainViewModel() {
            Items = new ObservableCollection<object>(GetItems());
            UpdateFiltrationLogic();
        }
        static IEnumerable<object> GetItems() {
            return new object[] { "A", "B", "C", "D", "E", "F", "G", "H" };
        }

        void UpdateFiltrationLogic() {
            CustomRowFilterCommand = new DelegateCommand<RowFilterArgs>(CustomRowFilter);
        }

        void CustomRowFilter(RowFilterArgs args) {
            if(HideOddItems && args.SourceIndex % 2 == 1)
                args.Visible = false;
            if(HideEvenItems && args.SourceIndex % 2 == 0)
                args.Visible = false;
        }
    }
}
