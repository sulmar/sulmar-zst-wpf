using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZST.WPF.WpfClient.ViewModels
{

    public class ClickerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        // Właściwość (Property)

        // public int Count { get; set; }

        // Back field
        private int count;
        
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                this.count = value;
                // TODO: wyslij powiadomienie

                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new                PropertyChangedEventArgs("Count"));

                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));
            }
        }


        private bool reverse;
        public bool Reverse
        {
            get
            {
                return reverse;
            }
            set
            {
                reverse = value;

                if (PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Reverse"));
            }
        }

        // ctor + 2 Tab
        public ClickerViewModel()
        {
            Count = 20;
        }

        public void ChangeCount()
        {
            if (Reverse)
            {
                Count--;                
            }
            else
            {
                Count++;
            }

            if (Count <= 0) { 
                Reverse = false;
            }
        }

        public void ResetCount()
        {
            Count = 0;
        }

        
    }
}
