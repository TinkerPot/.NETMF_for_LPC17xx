Threading Sample
================
This sample demonstrates the following:
-  Using many of the threading features.
-  Creating a thread, starting the thread, and waiting for the thread to 
   terminate.
-  Creating a timer causing a thread pool thread to invoke your method 
   periodically.
-  Making a thread wait on an event signaled by another thread.

This sample runs on the following devices:
-  The .NET Micro Framework SDK 4.0 Emulator.
-  Any physical device that implements the Time API and provides a 
   valid configuration.
-  Any emulator that implements the Microsoft.SPOT.Emulator.Time interface.


To build and run this sample:
1. Open Threading.sln in Visual Studio 2008.

2. To run this sample in the Emulator, open the project Properties page, click 
   the .NET Micro Framework tab, set the Transport property to Emulator, and 
   then select the emulator you want to use.

   To run this sample on a device, open the project Properties page, click the 
   .NET Micro Framework tab, set the Transport property to the transport that 
   your device supports, and then select the device you want to target. 

3. Open the file Threading.cs.  Set a breakpoint on the ThreadJoinDemo method.

4. In the Build menu, select Start Debugging (or press F5).  The breakpoint is 
   hit.  In the Output pane, click the Output tab.  Step through the code, 
   watching the Output pane.


Any actual application that uses this code will require modifications of this 
code.  This solution provides sample code, rather than ship-ready code, and is 
provided for instructional purposes only.
