using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace WebSiteSurvey.Data
{
    public class WebSiteSurveyRepository : IDisposable
    {
        bool _disposed = false;
        readonly SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
        private WebSiteSurveyContext _context;

        public WebSiteSurveyRepository()
        {
            _context = new WebSiteSurveyContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _handle.Dispose();
            }

            _disposed = true;
        }
    }
}