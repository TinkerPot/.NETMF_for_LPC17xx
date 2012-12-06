using System;
using System.Security.Cryptography; 
using System.IO; 


class RijndaelEncDec
{

    static Boolean Test()
    {
        Boolean bResult;

        Console.WriteLine("Testing RijndaelManaged encrypt/decrypt...");
        RijndaelManaged     rijnd = new RijndaelManaged();
        EncDec      ed = new EncDec();
        EncDecMul   edm = new EncDecMul();

        bResult = ed.TestAlgorithm(rijnd);
        bResult = edm.TestAlgorithm(rijnd) && bResult;

        return bResult;
    }

    public static void Main(String[] args) 
    {

        try {
            
            if (Test()) {
                Console.WriteLine("PASSED");
                Environment.ExitCode = 100;
            } else {
                Console.WriteLine("FAILED");
                Environment.ExitCode = 101;
            }

        }
        catch(Exception e) {
            Console.WriteLine();
            Console.Write("Exception: {0}", e.ToString());
            Environment.ExitCode = 101;
        }
        return;
    }
}
