using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesBackup
{
    public class Dvd : Storage
    {
        public bool isTwoSided { get; set; }

        public Dvd()
        {
            if(isTwoSided)
            {
                TotalStorage = StorageConstants.DVD_TWO_SIDE_STORAGE;
            }
            else
            {
                TotalStorage = StorageConstants.DVD_ONE_SIDE_STORAGE;
            }
            ReadSpeed = StorageConstants.DVD_READ_SPEED;
            WriteSpeed = StorageConstants.DVD_WRITE_SPEED;
        }

        public override void CopyData()
        {
            throw new NotImplementedException();
        }
        public override string GetDeficeInfo()
        {
            var additionalInfo = new StringBuilder();
            if(isTwoSided)
            {
                additionalInfo.Append("\nТип DVD: двухсторонний");
            }
            else
            {
                additionalInfo.Append("\nТип DVD: односторонний");
            }
            return base.GetDeficeInfo() + additionalInfo.ToString();
        }
    }
}
