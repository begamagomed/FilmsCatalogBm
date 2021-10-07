using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Models
{
    public class FilmsViewModel
    {
        public IEnumerable<FilmViewModel> Films { get; set; }

        public string AutorId { get; set; }
        public int PageIndex { get; set; }

        public int PageCount { get; set; }

        public PageSize PageSize { get; set; }
    }
}
