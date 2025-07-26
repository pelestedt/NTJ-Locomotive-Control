void Getsettings(){
 // Serial.println("Getsettings");
//Serial.println("");
//Serial.println("Skriver ut EEprominst");
//SSID 10 bytes 0-9
   ssid="";
   for (int mem=0; mem<10; mem++){ ssid += char(EEPROM.read(mem));}
  ssid.trim();
//Serial.print("ssid "); Serial.println(ssid);

//Loconame 20 bytes 10-29
loco_name="";
for (int mem=10; mem<30; mem++){ loco_name += char(EEPROM.read(mem));}
//Serial.print("loco_name "); Serial.println(loco_name);

myID=loco_name.toInt();

//Password 10 bytes 30-39
password="";
for (int mem=30; mem<40; mem++){ password += char(EEPROM.read(mem));}
password.trim();
//Serial.print("password "); //Serial.println(password);

//PWM frequency 2 bytes 70-71
pwmfrq=(256*EEPROM.read(70))+EEPROM.read(71);
//Serial.print("pwmfrq "); //Serial.println(pwmfrq);

//Zero_speed 2 bytes
zero_speed=(256*EEPROM.read(72))+EEPROM.read(73);
//Serial.print("zero_speed "); //Serial.println(zero_speed);

 //write  1 byte acceleration_time, 
acceleration_time=EEPROM.read(74);
//Serial.print("acceleration_time "); //Serial.println(acceleration_time);

//write  1 byte deceleration_time,
deceleration_time=EEPROM.read(75);
//Serial.print("deceleration_time "); //Serial.println(deceleration_time); 

//write  1 byte fullspeed
fullspeed=EEPROM.read(76)*10;
//Serial.print("fullspeed "); //Serial.println(fullspeed);
  
  //write  1 byte slowspeed
slowspeed=EEPROM.read(77)*10;
//Serial.print("slowspeed "); //Serial.println(slowspeed);
 
  //write  1 byte halfspeed
halfspeed=EEPROM.read(78)*10;
//Serial.print("halfspeed "); //Serial.println(halfspeed);

  //write  1 byte Shuntingspeed
Shuntingspeed=EEPROM.read(79);
//Serial.print("Shuntingspeed "); //Serial.println(Shuntingspeed);
  
  //write  1 byte startwhistle
startwhistle=EEPROM.read(80);
//Serial.print("startwhistle "); //Serial.println(startwhistle);

  
  //write  1 byte approachwhistle
approachwhistle=EEPROM.read(81);
//Serial.print("approachwhistle "); //Serial.println(approachwhistle);
  
  //write  1 byte max_pulserate
max_pulserate =EEPROM.read(82);
//Serial.print("max_pulserate "); //Serial.println(max_pulserate);
  
  //write  1 byte min_pulserate
min_pulserate=EEPROM.read(83);
//Serial.print("min_pulserate "); //Serial.println(min_pulserate);
  
  //write  1 byte pulselength
pulselength=EEPROM.read(84);
//Serial.print("pulselength "); //Serial.println(pulselength);
  
 //Smoketime
smoke_timer =EEPROM.read(85);
//Serial.print("smoke_timer "); //Serial.println(smoke_timer);
 
//creepspeed
creepspeed=EEPROM.read(86);
//Serial.print("creepspeed "); //Serial.println(creepspeed);

//mindwell
mindwell=EEPROM.read(87);
//Serial.print("mindwell "); //Serial.println(mindwell);

//maxdwell 
maxdwell=EEPROM.read(88);
//Serial.print("maxdwell "); //Serial.println(maxdwell);

}// Slut Getsettings
