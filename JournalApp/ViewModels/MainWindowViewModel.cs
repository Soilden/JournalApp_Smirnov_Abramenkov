﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalApp.ViewModels.Base;

namespace JournalApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";

        /// <summary>Заголовок окна</summary>
        private string Title 
        {
            get => _Title;
            //set
            //{
            //    //if (Equals(_Title, value)) return;
            //   //_Title = value;
            //   //OnPropertyChanged();
            
            //   Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
        #endregion
    }
}