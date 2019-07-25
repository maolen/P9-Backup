using System;
using System.Text;

namespace FilesBackup
{
    public abstract class Storage
    {
        private double _memoryCapacity;
        private double _freeStorage;
        private double _readSpeed;
        private double _writeSpeed;

        /// <summary>
        /// Имя устройства.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Модель устройства.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Объём общей памяти в мегабайтах.
        /// </summary>
        public double TotalStorage
        {
            get
            {
                return _memoryCapacity;
            }
            protected set
            {
                if (value < 0)
                {
                    _memoryCapacity = Math.Abs(value);
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Объём общей памяти не может быть равен нулю!");
                }
                else
                {
                    _memoryCapacity = value;
                }
            }
        }

        /// <summary>
        /// Объём свободной памяти в мегабайтах.
        /// </summary>
        public double FreeStorage
        {
            get
            {
                return _freeStorage;
            }
            protected set
            {
                if (value < 0)
                {
                    _freeStorage = Math.Abs(value);
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Объём свободной памяти не может быть равен нулю!");
                }
                else if (value > TotalStorage)
                {
                    throw new ArgumentOutOfRangeException("О");
                }
                else
                {
                    _freeStorage = value;
                }
            }
        }

        /// <summary>
        /// Скорость чтения в мегабайт в секунду.
        /// </summary>
        public double ReadSpeed
        {
            get
            {
                return _readSpeed;
            }
            protected set
            {
                if (value < 0)
                {
                    _readSpeed = Math.Abs(value);
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Скорость чтения не может быть равна нулю!");
                }
                else
                {
                    _readSpeed = value;
                }
            }
        }

        /// <summary>
        /// Скорость записи в мегабайт в секунду.
        /// </summary>
        public double WriteSpeed
        {
            get
            {
                return _writeSpeed;
            }
            protected set
            {
                if (value < 0)
                {
                    _writeSpeed = Math.Abs(value);
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Скорость записи не может быть равна нулю!");
                }
                else
                {
                    _writeSpeed = value;
                }
            }
        }


        /// <summary>
        /// Получение информации об устройстве.
        /// </summary>
        /// <returns></returns>
        public virtual string GetDeficeInfo()
        {
            var deviceInfo = new StringBuilder();
            deviceInfo.Append($"\nНазвание устройства: {Name}");
            deviceInfo.Append($"\nМодель устройства: {Model}");
            deviceInfo.Append($"\nОбъём общей памяти: {TotalStorage}");
            deviceInfo.Append($"\nОбъём свободной памяти: {FreeStorage}");
            deviceInfo.Append($"\nСкорость записи данных: {ReadSpeed}");
            deviceInfo.Append($"\nСкорость чтения данных: {WriteSpeed}");
            return deviceInfo.ToString();
        }

        /// <summary>
        /// Копирование данных на устройство.
        /// </summary>
        /// <returns></returns>
        public abstract void CopyData();
    }
}
