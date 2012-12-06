using System;
using System.Security.Cryptography; 
using System.IO; 

class SimpleEncDecRijndael
{
    static void PrintByteArray(Byte[] arr)
    {
        int i;
        for (i=0; i<arr.Length; i++) {
            Console.Write(arr[i] + "    ");
            if ( (i+9)%8 == 0 ) Console.WriteLine();
        }
        if (i%8 != 0) Console.WriteLine();
    }

    static Boolean Compare(Byte[] rgb1, Byte[] rgb2) { 
        int     i;
        if (rgb1.Length != rgb2.Length) return false;
        for (i=0; i<rgb1.Length; i++) {
            if (rgb1[i] != rgb2[i]) return false;
        }
        return true;
    }

    static Boolean Test(Aes aes, CipherMode md)
    {

        Byte[]  PlainText = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
        Byte[]  Key = {1, 1, 1, 1, 1, 1, 1, 1,2,2,2,2,2,2,2,2};
        Byte[]  IV = {100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115};
        
        Console.WriteLine("Encrypting the following bytes:");
        PrintByteArray(PlainText);
        
        aes.Mode = md;

        Console.WriteLine("AES default key size = " + aes.KeySize);
        ICryptoTransform sse = aes.CreateEncryptor(Key, IV);
        Console.WriteLine("SSE mode = " + aes.Mode);
        MemoryStream ms = new MemoryStream();
        CryptoStream    cs = new CryptoStream(ms, sse, CryptoStreamMode.Write);
        cs.Write(PlainText,0,PlainText.Length);
        cs.FlushFinalBlock();
        byte[] CipherText = ms.ToArray();
        cs.Close();

        Console.WriteLine("Cyphertext:");
        PrintByteArray(CipherText);
        

        Console.WriteLine("Decrypting...");

        ICryptoTransform ssd = aes.CreateDecryptor(Key, IV);
        Console.WriteLine("SSD mode = " + aes.Mode);
        cs = new CryptoStream(new MemoryStream(CipherText), ssd, CryptoStreamMode.Read);

        byte[] NewPlainText = new byte[PlainText.Length];
        cs.Read(NewPlainText,0,PlainText.Length);

        PrintByteArray(NewPlainText);
        
        if (!Compare(PlainText, NewPlainText)) {
        	Console.WriteLine("ERROR: roundtrip failed");
        	return false;
        }
        
        return true;
    }

    public static int Main(String[] args) 
    {

        try {
            if (!Test(new AesManaged(), CipherMode.ECB))
			{
				Console.WriteLine("AesManaged/ECB failed");
				return 123;
			}

			if (!Test(new AesManaged(), CipherMode.CBC))
			{
				Console.WriteLine("AesManaged/CBC failed");
				return 123;
			}

			if (AesCSPSupported())
			{
				if (!Test(new AesCryptoServiceProvider(), CipherMode.ECB))
				{
					Console.WriteLine("AesCryptoServiceProvider/ECB failed");
					return 123;
				}

				if (!Test(new AesCryptoServiceProvider(), CipherMode.CBC))
				{
					Console.WriteLine("AesCryptoServiceProvider/CBC failed");
					return 123;
				}
			}

			Console.WriteLine("Test Passed");
			return 100;
        }
        catch(Exception e) {
            Console.Write("Exception: {0}", e.ToString());
            return 123;
        }
    }

	// AesCryptoServiceProvider is only supported in WinXP and higher (v5.1+)
	//
	public const int AesCSPSupportedMajorVer = 5;
	public const int AesCSPSupportedMinorVer = 1;
	
	public static bool AesCSPSupported()
	{
		int major = Environment.OSVersion.Version.Major;
		int minor = Environment.OSVersion.Version.Minor;

		if (major > AesCSPSupportedMajorVer)
			return true;

		if ((major == AesCSPSupportedMajorVer) && (minor >= AesCSPSupportedMinorVer))
			return true;

		return false;
	}

}
