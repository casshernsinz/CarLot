//Getters and Setters

//public int GenSerialNumber
//{
//    get { return this.serialNumber; }
//    set
//    {
//        var randomVIN = new Random();
//        //int temp = 0;
//        for (int i = 0; i < 1; i++)
//        {
//            int temp = randomVIN.Next(100000, 999999);
//            Console.WriteLine("The serial number is " + temp);
//        }
//    }
//}
//public char[] GenVINPrefix
//{
//    get { return this.preVIN; }
//    set
//    {
//        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//        var temp = new char[4];
//        var randomPreVIN = new Random();

//        for (int i = 0; i < temp.Length; i++)
//        {
//            temp[i] = alphabet[randomPreVIN.Next(alphabet.Length)];
//        }
//        var preVIN = new string(temp);
//        Console.WriteLine("The VIN prefix is " + preVIN);
//    }
//}




//Get -- Set Methods

//public int GetSerialNumber()
//{
//    return this.serialNumber;
//}

//public int SetGenSerialNumber()
//{
//    var randomVIN = new Random();
//    int temp = 0;
//    for (int i = 0; i < 1; i++)
//    {
//        temp = randomVIN.Next(100000, 999999);
//        Console.WriteLine("The serial number is " + temp);
//    }
//    this.serialNumber = temp;
//    return this.serialNumber;
//}


//Wheels

//public int Wheels
//{
//    get { return wheels; }
//    set
//    {
//        if (value % 2 == 0)
//        {
//            wheels = value;
//        } else
//        {
//           throw new ArgumentOutOfRangeException($"{nameof(value)} must be an even number dawg");
//        }
//    }
//}