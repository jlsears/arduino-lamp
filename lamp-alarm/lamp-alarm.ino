#include <SoftwareSerial.h>
SoftwareSerial BT (10, 11); // RX, TX
String command = ""; // Stores response of bluetooth device

void setup() {
  Serial.begin(9600);
  Serial.println ("Type  AT commands");
  BT.begin (9600); // HC-06 usually default baud-rate
}

// waiting for data to come from bluetooth
void loop() {
  if(BT.available())
  {
    while(BT.available())
    {
      delay (10); // delay added to make thing stable
      char c = BT.read (); // conduct serial read
      command += c; // build the string  
    } // end while   
    Serial.println (command);
    command = ""; // no repeats
   } // end 1st if

   if (Serial.available())
   {
      delay (10);
      BT.write (Serial.read());
    } // end 2nd if
} // end void loop
