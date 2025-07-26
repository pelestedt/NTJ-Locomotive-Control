void every1000ms()
{
  client.println("Anslutning från windows accepterad");
  // code to be repeated every 1000ms (every second)
  //Increment time the smoke generator has been on and turn it off after timeout
/*
//int(current_PWM);//Serial.print("  ");
//int(read_speed);//Serial.print(" error= ");
//int(error);//Serial.print("  ");//int(kp*error);
//Serial.print(" ki= ");//Serial.println(int(ki*1000));

 Serial.print("current_PWM ");Serial.println(current_PWM);
 Serial.print("set_speed ");Serial.println(set_speed);
 Serial.print("desired_speed "); Serial.println(desired_speed);
 Serial.print("read_speed "); Serial.println(read_speed);
 Serial.print("error "); Serial.println(error);
 Serial.println("");
*/
  //Check that a time > 0 is set
  if (smoke_timer > 0) {
    // Check if smoke output is on increment smoke_timer and set button on throttle on
    if (FunctionKey[6] == true) {
      smokeon = smokeon + 1;
    }
    // Check if time has elapsed and if it has, reset timer and output
    if (smokeon > (smoke_timer * 60)) {
      digitalWrite(OUT6, LOW);
      FunctionKey[6] = false;
      smoke_timer = 0;
    }
    if (FunctionKey[6] == false) {
      digitalWrite(OUT6, LOW);
    }
  }
}
