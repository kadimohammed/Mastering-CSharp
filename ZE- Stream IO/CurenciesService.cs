using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZE__Stream_IO
{
    internal class CurenciesService : IDisposable
    {
        HttpClient _httpClient;
        private bool _disposed { get; set; }
        private int[] _largeArray;


        public CurenciesService() 
        { 
            _httpClient = new HttpClient();
            _largeArray = new int[1000];
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this); // Évite d'appeler le finaliseur
        }

        // true => (managed et unmanaged)
        // false => (unmanaged + large filds)
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            
            if(disposing)
            {
                _httpClient?.Dispose(); // Libération des ressources managées
            }
            // Libération des object non managées
            _largeArray = null;  // set large filds to null
            _disposed = true;
        }

        ~CurenciesService()
        {
            Dispose(false);
        }

        public string GetCurencies()
        {
            string result = _httpClient.GetStringAsync("https://coinbase.com/api/v2/currencies").Result;
            return result;
        }
    }
}
