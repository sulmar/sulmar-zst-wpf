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

        private bool isPlaying;
        public bool IsPlaying
        {
            get
            {
                return isPlaying;
            }
            set
            {
                isPlaying = value;
                OnPropertyChanged(nameof(IsPlaying));
            }
        }

        public TimeSpan PlayingTime {  get; set; }

        // ctor + 2 Tab
        public ClickerViewModel()
        {
            IsPlaying = false;

            Count = 20;

            PlayingTime = TimeSpan.FromSeconds(5);            
        }

       

        public void StartPlaying()
        {
            Count = 0;
            IsPlaying = true;
        }

        public void StopPlaying()
        {
            IsPlaying = false;
        }

        public bool CanChangeCount()
        {
            return IsPlaying;
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
