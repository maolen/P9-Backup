using System;
using static System.Console;

namespace Backup
{
    public abstract class Storage
    {
        private double _memoryCapacity;
        private double _freeMemory;
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
        public double MemoryCapacity
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
        public double FreeMemory
        {
            get
            {
                return _freeMemory;
            }
            protected set
            {
                if (value < 0)
                {
                    _freeMemory = Math.Abs(value);
                }
                else if (value == 0)
                {
                    throw new ArgumentException("Объём свободной памяти не может быть равен нулю!");
                }
                else if (value > MemoryCapacity)
                {
                    throw new ArgumentOutOfRangeException("О");
                }
                else
                {
                    _freeMemory = value;
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
        /// Показывает объём общей памяти в мегабайтах.
        /// </summary>
        /// <returns></returns>
        protected abstract double GetMemoryCapacity();

        /// <summary>
        /// Показывает объём свободной памяти в мегабайтах.
        /// </summary>
        /// <returns></returns>
        protected abstract double GetFreeMemory();

        /// <summary>
        /// Получение информации об устройстве.
        /// </summary>
        /// <returns></returns>
        protected abstract string GetDeficeInfo();

        /// <summary>
        /// Копирование данных на устройство.
        /// </summary>
        /// <returns></returns>
        protected abstract void CopyData();
    }
}
