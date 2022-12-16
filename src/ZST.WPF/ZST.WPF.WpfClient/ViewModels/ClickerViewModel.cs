using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZST.WPF.WpfClient.ViewModels
{

    public class ClickerViewModel :  BaseViewModel
    {
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
              
                OnPropertyChanged(nameof(Count));               
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

                OnPropertyChanged(nameof(Reverse));
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
