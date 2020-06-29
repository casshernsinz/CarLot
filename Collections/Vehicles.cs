using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Collections
{
    class Vehicles
    {
        private string model;
        private string make;
        private string preVIN;
        private int serialNumber;
        public string VIN;
        //private int wheels;
        public Vehicles()
        {
            GenSerialNumber = this.serialNumber;
            GenVINPrefix = this.preVIN;
            this.VIN = this.preVIN + "-" + GenSerialNumber;


            //Console.WriteLine("The VIN is " + this.preVIN + "-" + this.GenSerialNumber);
            //Console.WriteLine("The VIN is " + this.VIN);
        }

        public int GenSerialNumber
        {
            get { return this.serialNumber; }
            private set
            {
                var randomVIN = new Random();
                int temp = 0;
                for (int i = 0; i < 1; i++)
                {
                    temp = randomVIN.Next(100000, 999999);
                    //Console.WriteLine("The serial number is " + temp);
                }
                this.serialNumber = temp;
            }

        }
        public string GenVINPrefix
        {
            get { return this.preVIN; }
            private set
            {
                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                char[] temp = new char[4];
                Random randomPreVIN = new Random();

                for (int i = 0; i < 4; i++)
                {
                    temp[i] = alphabet[randomPreVIN.Next(alphabet.Length)];
                }

                string preVIN = new string(temp);
                //Console.WriteLine("The VIN prefix is " + preVIN);
                this.preVIN = preVIN;
            }
        }
        public string Make { get; set; }
    }


}
