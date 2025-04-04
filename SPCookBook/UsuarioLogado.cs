using SPCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPCookBook
{
    public static class UsuarioLogado
    {
        public static Usuario CurrentUser { get; set; }
    }
}