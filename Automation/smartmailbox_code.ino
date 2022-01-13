
/* Sweep
 by BARRAGAN <http://barraganstudio.com>
 This example code is in the public domain.

 modified 8 Nov 2013
 by Scott Fitzgerald
 http://www.arduino.cc/en/Tutorial/Sweep
*/

#include <Servo.h>
#include <Keypad.h>

const byte ROWS = 4; 
const byte COLS = 3; 

char hexaKeys[ROWS][COLS] = {
  {'1', '2', '3'},
  {'4', '5', '6'},
  {'7', '8', '9'},
  {'*', '0', '#'}
};

byte rowPins[ROWS] = {9, 8, 7, 6}; 
byte colPins[COLS] = {5, 4, 3}; 

Keypad customKeypad = Keypad(makeKeymap(hexaKeys), rowPins, colPins, ROWS, COLS); 
Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards

int pos = 0;    // variable to store the servo position

void sonarserial()
{
  Serial.println("1234");
  delay(100);
}

void setup() {
  Serial.begin(9600);
  myservo.attach(10);  // attaches the servo on pin 9 to the servo object
 
 //myservo.write(90);
  //myservo.write(0);
}
int incomingByte=0;
void aberturaAuto()
{
 // read from port 1, send to port 0:
  if (Serial.available()) {
    int inByte = Serial.read();
    Serial.write(inByte);
    if (inByte=='1')
    {Serial.write("FECHAR");
    myservo.write(90);
    }
    else if (inByte=='2')
    {
    
    Serial.write("ABRIR");
    myservo.write(0);
    }
  } 
}
String cod;
 void teclado()
 {
 char customKey = customKeypad.getKey();
  
  
  if (customKey){
    if (cod=='*'||cod=='#'){cod="";}
    Serial.println(customKey);
    if (customKey=='#'){
      if (cod=="1234")
      {
        cod="";
        myservo.write(0);
      }else
      {cod="";}
      }else if (customKey=='*') 
      {
        myservo.write(90);
        cod="";
      }
    cod.concat(customKey);
    
    Serial.println("cod:");
    Serial.println(cod);}
 }
void loop() 
{ 
    sonarserial();
   //aberturaAuto();
   //teclado();

}
