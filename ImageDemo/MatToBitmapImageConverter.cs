using Microsoft.Win32.SafeHandles;
//using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ImageDemo
{
    public class MatToBitmapImageConverter : IValueConverter, IDisposable, ICloneable
    {
        #region IDisposable, ICloneable Members

        bool disposed = false;
        SafeHandle handler = new SafeFileHandle(IntPtr.Zero, true);

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                handler.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            object result = null;
            try
            {
                //Bitmap src = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(value as Mat);
                //if (src != null)
                //{
                //    MemoryStream ms = new MemoryStream();
                //    ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                //    BitmapImage image = new BitmapImage();
                //    image.BeginInit();
                //    ms.Seek(0, SeekOrigin.Begin);
                //    image.StreamSource = ms;
                //    image.EndInit();
                //    result = image;
                //}
                return result;
            }
            catch (Exception)
            {
                return result;
            }
            finally
            {
                this.Dispose();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
