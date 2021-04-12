using System;

public class Operations
{
	public Operations()
	{
    }

    public double Acos(double val)
    {
        return Math.Acos(val);
    }

    public double Cos(double val)
    {
        return Math.Cos(val);
    }

    public double Asin(double val)
    {
        return Math.Asin(val);
    }

    public double Sin(double val)
    {
        return Math.Sin(val);
    }

    public double Atan(double val)
    {
        return Math.Atan(val);
    }

    public double Tan(double val)
    {
        return Math.Tan(val);
    }

    public double Abs(double val)
    {
        return Math.Abs(val);
    }

    public double Sqrt(double val, double exp)
    {
        double res = val;

        while(exp > 1)
        {
            res = Sqrt(Math.Sqrt(val), exp-1);
        }

        return res;
    }

    public double Pow(double val, double exp)
    {
        double res = val;

        while (exp > 1)
        {
            res = Pow(Math.Pow(val), exp - 1);
        }

        return res;
    }

    public double DegToRad(double deg)
    {
        return deg * Math.PI / 180;
    }

    public double RadToDeg(double rad)
    {
        return rad / Math.PI * 180;
    }

    public string DecToHex(int dec)
    {
        string hex = "";

        while(dec > 15)
        {
            switch (dec % 16)
            {
                case 0:
                    hex += "0";
                    break;
                case 1:
                    hex += "1";
                    break;
                case 2:
                    hex += "2";
                    break;
                case 3:
                    hex += "3";
                    break;
                case 4:
                    hex += "4";
                    break;
                case 5:
                    hex += "5";
                    break;
                case 6:
                    hex += "6";
                    break;
                case 7:
                    hex += "7";
                    break;
                case 8:
                    hex += "8";
                    break;
                case 9:
                    hex += "9";
                    break;
                case 10:
                    hex += "A";
                    break;
                case 11:
                    hex += "B";
                    break;
                case 12:
                    hex += "C";
                    break;
                case 13:
                    hex += "D";
                    break;
                case 14:
                    hex += "E";
                    break;
                case 15:
                    hex += "F";
                    break;
            }
            DecToHex((dec - dec % 16) / 16);
        }
        hex += dec;
        return hex;
    }
    
    public int HexToDec(string hex)
    {
        int dec = 0;

        for(int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case "1":
                    dec += Math.Pow(i * 4) * 1;
                    break;
                case "2":
                    dec += Math.Pow(i * 4) * 2;
                    break;
                case "3":
                    dec += Math.Pow(i * 4) * 3;
                    break;
                case "4":
                    dec += Math.Pow(i * 4) * 4;
                    break;
                case "5":
                    dec += Math.Pow(i * 4) * 5;
                    break;
                case "6":
                    dec += Math.Pow(i * 4) * 6;
                    break;
                case "7":
                    dec += Math.Pow(i * 4) * 7;
                    break;
                case "8":
                    dec += Math.Pow(i * 4) * 8;
                    break;
                case "9":
                    dec += Math.Pow(i * 4) * 9;
                    break;
                case "A":
                    dec += Math.Pow(i * 4) * 10;
                    break;
                case "B":
                    dec += Math.Pow(i * 4) * 11;
                    break;
                case "C":
                    dec += Math.Pow(i * 4) * 12;
                    break;
                case "D":
                    dec += Math.Pow(i * 4) * 13;
                    break;
                case "E":
                    dec += Math.Pow(i * 4) * 14;
                    break;
                case "F":
                    dec += Math.Pow(i * 4) * 15;
                    break;
            }
        }
        return dec;
    }
    
    public string DecToBin(int dec) { 
        string bin = "";

        while(dec > 1)
        {
            switch (dec % 2)
            {
                case 0:
                    bin += "0";
                    break;
                case 1:
                    bin += "1";
                    break;
            }
        DecToBin((dec - dec % 2) / 2);
        }
        bin += dec;
    return bin;
    }

    public string DecToOct(int dec)
    {
        string oct = "";

        while (dec > 7)
        {
            switch (dec % 8)
            {
                case 0:
                    bin += "0";
                    break;
                case 1:
                    bin += "1";
                    break;
                case 2:
                    bin += "2";
                    break;
                case 3:
                    bin += "3";
                    break;
                case 4:
                    bin += "4";
                    break;
                case 5:
                    bin += "5";
                    break;
                case 6:
                    bin += "6";
                    break;
                case 7:
                    bin += "7";
                    break;
            }
            DecToOct((dec - dec % 7) / 7);
        }
        oct += dec;
        return oct;
    }

    public double Real(string complex)
    {
        string[] splits = complex.Split('+', '-');

        return Convert.ToDouble(splits[0]);
    }

    public double Complex(string complex)
    {
        string[] splits = complex.Split('+', '-');

        return Convert.ToDouble(splits[1].Trim("i"));
    }
}
