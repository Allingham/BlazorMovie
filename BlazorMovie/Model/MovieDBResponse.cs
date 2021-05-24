using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Model
{
    public class MovieDBResponse
    {
        public int page { get; set; }
        public ObservableCollection<MovieItem> results { get; set; }
    }
}
