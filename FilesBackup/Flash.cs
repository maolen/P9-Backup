using System;
using static System.Console;
using System.Text;

namespace FilesBackup
{
    public class Flash : Storage
    {
        public Flash()
        {
            ReadSpeed = StorageConstants.USB_3_READ_SPEED;
            WriteSpeed = StorageConstants.USB_3_WRITE_SPEED;
        }
        public override void CopyData()
        {
            throw new NotImplementedException();
        }

        public override string GetDeficeInfo()
        {
            return base.GetDeficeInfo();
        }
    }
}
