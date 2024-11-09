using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	public class FileHandler : IDisposable
	{
		private FileStream managedFileStream;
		private IntPtr unmanagedResource;
		public FileHandler(string filePath) 
		{
			managedFileStream = new FileStream(filePath, FileMode.OpenOrCreate);
			unmanagedResource = Marshal.AllocHGlobal(100);
		}
		public void WriteToFile(string content) 
		{ 
			byte[] info = new UTF8Encoding(true).GetBytes(content);
			managedFileStream.Write(info, 0, info.Length); 
		}

		public void Dispose()
		{
			CustomeDispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void CustomeDispose(bool IsManagedDisposing)
		{
			if (IsManagedDisposing)
			{
				// Dispose managed resources
				if (managedFileStream != null)
				{
					managedFileStream.Close();
					managedFileStream.Dispose();
					managedFileStream = null;
				}
			}
			// Dispose unmanaged resources
			if (unmanagedResource != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(unmanagedResource);
				unmanagedResource = IntPtr.Zero;
			}
		}
		~FileHandler()
		{
			CustomeDispose(false);
		}
	}
}
