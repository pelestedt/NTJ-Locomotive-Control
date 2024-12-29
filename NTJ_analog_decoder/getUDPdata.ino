void getUDPdata() {
  // if there's data available, read a packet
  int packetSize = Udp.parsePacket();
  if (packetSize) {
  // read the packet into packetBufffer
    int n = Udp.read(packetBuffer, 20);
    packetBuffer[n] = 0;
    Serial.print("Inkommet ");
    Serial.println(packetBuffer);
    //Decode the entire message
    //Get ID
    char IDENT = packetBuffer[0];
    //Get DCC address
    String address = "";
    int t = 1;
    while (isDigit(packetBuffer[t])) {
      address = address + packetBuffer[t];
      t++;
    }
    int DCCaddress = address.toInt();
    //Get message type
    char TYPE = packetBuffer[t];
    t++;
   
    //Act after type
    if (TYPE == 'H') {
      //Get speed value
      String speed = "";
      while (isDigit(packetBuffer[t])) {
        speed = speed + packetBuffer[t];
        t++;
      }
      SPEED = speed.toInt();
      
      //Get direction
      t++;
      String riktning = "";
      riktning = packetBuffer[t];
      DIRECTION = riktning.toInt();
      
      //Get sequence number
      t = t + 2;
      String q = "";
      while (isDigit(packetBuffer[t])) {
        q = q + packetBuffer[t];
        t++;
      }
      Q = q.toInt();
      
    }

    if (TYPE == 'F') {
      //Get Function key
      String keyvalue = "";
      while (isDigit(packetBuffer[t])) {
        keyvalue = keyvalue + packetBuffer[t];
        t++;
      }
      KEY = keyvalue.toInt();
      
      //Get sequence number
      t++;
      String q = "";
      while (isDigit(packetBuffer[t])) {
        q = q + packetBuffer[t];
        t++;
      }
      Q = q.toInt();
      
    }
    //Check to who the message is
    if (IDENT == 'I' && DCCaddress == myIDa) {
      
      if (TYPE == 'H') {
        set_direction_a = DIRECTION;
        Serial.println("Riktning och hastighet satt för A");
        throttle_speed_a = SPEED+SPEED;
      }
      if (TYPE == 'F') {
        Funktionstangenter = KEY;
        //uppdatera funktionstangenternas spegelarea
        for (int f = 0; f < 29; f++) {
          FunctionKey_a[f] = 1;
          int mask = pow(2, f);
          if ((Funktionstangenter & mask) == 0) FunctionKey_a[f] = 0;
        }  //slut uppdatering av spegelarea
      }
    }

    if (IDENT == 'I' && DCCaddress == myIDb) {
      
      if (TYPE == 'H') {
        set_direction_b = DIRECTION;
        throttle_speed_b = SPEED+SPEED;
        Serial.println("Riktning och hastighet satt för B");
      }
      if (TYPE == 'F') {
        Funktionstangenter = KEY;
        //uppdatera funktionstangenternas spegelarea
        for (int f = 0; f < 29; f++) {
          FunctionKey_b[f] = 1;
          int mask = pow(2, f);
          if ((Funktionstangenter & mask) == 0) FunctionKey_b[f] = 0;
        }  //slut uppdatering av spegelarea
      }
    }


    //Skicka ack
    Udp.beginPacket(IPAddress(255, 255, 255, 255), 8888);
    Udp.print(Q);
    Udp.endPacket();
    Serial.print("Skickat Q ");Serial.println(Q);
    for(int d=0;d<21;d++) packetBuffer[d]=0;
  }//Slut hantering av inkommet data
}  //slut rutin getUDPdata
