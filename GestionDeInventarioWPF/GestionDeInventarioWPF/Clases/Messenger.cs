using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeInventarioWPF.Clases
{
    public static class Messenger
    {
        public static event Action<Uri> PageRequested;

        public static void RequestPage(Uri pageUri)
        {
            PageRequested?.Invoke(pageUri);
        }
    }
}
