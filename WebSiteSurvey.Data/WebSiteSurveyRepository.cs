using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace WebSiteSurvey.Data
{
    public class WebSiteSurveyRepository : IDisposable
    {
        bool _disposed;
        readonly SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
        private readonly WebSiteSurveyContext _context;

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

        public void Insert(Models.WebSiteSurvey webSiteSurvey)
        {
            _context.WebSiteSurveys.Add(webSiteSurvey);
            _context.SaveChanges();
        }

        public IList<Models.WebSiteSurvey> GetAll()
        {
            return _context.WebSiteSurveys.ToList();
        }
    }
}