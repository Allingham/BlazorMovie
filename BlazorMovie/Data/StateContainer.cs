using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using BlazorMovie.Model;

namespace BlazorMovie.Data
{
    public class StateContainer
    {
        private string _savedString;

        public string SavedString
        {
            get => _savedString;
            set
            {
                _savedString = value;
                NotifyStateChanged();
            }
        }

        private MovieItem _savedMovie;

        public MovieItem SavedMovie
        {
            get => _savedMovie;
            set
            {
                _savedMovie = value;
                NotifyStateChanged();
            }
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
