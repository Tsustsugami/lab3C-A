using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public enum MeasureType { l, M3, ML, bar };
    public class Volume
    {
        private double value;
        private MeasureType type;
        public Volume(double value, MeasureType type)
        {
            this.value = value;
            this.type = type;
        }
        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.l:
                    typeVerbose = "л.";
                    break;
                case MeasureType.M3:
                    typeVerbose = "М3.";
                    break;
                case MeasureType.ML:
                    typeVerbose = "м.л.";
                    break;
                case MeasureType.bar:
                    typeVerbose = "баррель";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
        public static Volume operator +(Volume instance, double number)
        {
            var newValue = instance.value + number;
            var Volume = new Volume(newValue, instance.type);
            return Volume;
        }
        public static Volume operator +(double number, Volume instance)
        {
            return instance + number;
        }
        public static Volume operator *(Volume instance, double number)
        {
            return new Volume(instance.value * number, instance.type);
        }

        public static Volume operator *(double number, Volume instance)
        {
            return instance * number;
        }

        public static Volume operator -(Volume instance, double number)
        {
            return new Volume(instance.value - number, instance.type);
        }

        public static Volume operator -(double number, Volume instance)
        {
            return instance - number;
        }

        public static Volume operator /(Volume instance, double number)
        {
            return new Volume(instance.value / number, instance.type);
        }

        public static Volume operator /(double number, Volume instance)
        {
            return instance / number;
        }
        public static Volume comparison(Volume instance, Volume instance2)
        {
            if (instance.value>instance2.To(instance.type).value)
            {
                return instance;
            }
            else
            {
                return instance2;
            }
        }

        public Volume To(MeasureType newType)
        {
            var newValue = this.value;
            if (this.type == MeasureType.l)
            {
                switch (newType)
                {
                    case MeasureType.l:
                        newValue = this.value;
                        break;
                    case MeasureType.M3:
                        newValue = this.value / 1000;
                        break;
                    case MeasureType.ML:
                        newValue = this.value *1000;
                        break;
                    case MeasureType.bar:
                        newValue = this.value /158.99;
                        break;
                }
            }
            else if (newType == MeasureType.l) 
            {
                switch (this.type) 
                {
                    case MeasureType.l:
                        newValue = this.value;
                        break;
                    case MeasureType.M3:
                        newValue = this.value * 1000; 
                        break;
                    case MeasureType.ML:
                        newValue = this.value / 1000; 
                        break;
                    case MeasureType.bar:
                        newValue = this.value / 158.99;
                        break;
                }
            }
            return new Volume(newValue, newType);
        }
        public static Volume operator +(Volume instance1, Volume instance2)
        {
            return instance1 + instance2.To(instance1.type).value;
        }

        public static Volume operator -(Volume instance1, Volume instance2)
        {
            return instance1 - instance2.To(instance1.type).value;
        }
        public static Volume operator *(Volume instance1, Volume instance2)
        {
            return instance1 * instance2.To(instance1.type).value;
        }
        public static Volume operator /(Volume instance1, Volume instance2)
        {
            return instance1 / instance2.To(instance1.type).value;
        }
    }
}

