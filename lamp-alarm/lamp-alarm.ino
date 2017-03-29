// Including SoftwareSerial library, which allows serial communication on other digital pins of the Arduino
// (rather than just 0 and 1) using software to replicate the functionality
#include <SoftwareSerial.h>

// Setting BT variable to new serial port
// RX, TX
SoftwareSerial BT (10, 11); 

// Stores response of HC-06 Bluetooth device
String command = ""; 

void setup() {
  // Sets the speed (baud rate) for serial communication
  // 9600: HC-06 usual default baud-rate
  Serial.begin(9600);
  Serial.println ("Type  AT commands");
  BT.begin (9600); 
}

// waiting for data to come from bluetooth
void loop() {
  // if we're getting a signal from the bluetooth
  // then will read from bluetooth and write to usb serial
  if(BT.available())
  {
    while(BT.available())
    {
      // delay added to make thing stable
      delay (10); 
      // conduct serial read
      char c = BT.read ();
      // build the string  
      command += c;  
    } // end while   
    Serial.println (command);
    // no repeats
    command = ""; 
   } // end 1st if

   if (Serial.available())
   {
      delay (10);
      BT.write (Serial.read());
    } // end 2nd if
} // end void loop
