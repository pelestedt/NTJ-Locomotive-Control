/*
  Implementation for For WiFi control of Ananlogue locomotive by UDP messages sent from modified DCC++EX command station

  Change log:
  2024-01-03   ver 1.0 First version based NTJ_UDP_decoder 1.6
  2024-07-02   ver 1.1 Rewritten parsing of incoming messages
2024-07-02   ver 1.2 Rewritten to fit esp8266 Wemos D1R2 and ?? H-brigdge

*/
const String ver = "1.2.1";
/*

   THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
  DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
  ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
  ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#include <ESP8266WiFi.h>
//#include "WiFi.h"
#include <WiFiUdp.h>
#include "Config.h"
#include <WiFiClient.h>
//#include <ESP8266mDNS.h>        // Include the mDNS library

//#include <ESP.h>

WiFiServer server(44);
WiFiClient client;
int lastpwma = 0;
void setup() {
  Serial.begin(115200);
  Serial.println(" ");
  Serial.println("NTJ analog Locomotive control ver " + ver);
analogWriteFreq(pwmfrq);

  WiFi.mode(WIFI_STA);
  //Initialize I/O
    pinMode(TRACK6, OUTPUT);
  digitalWrite(TRACK6, OFF);
   pinMode(TRACK3, OUTPUT);
  digitalWrite(TRACK3, OFF);
  pinMode(TRACK4, OUTPUT);
  digitalWrite(TRACK4, OFF);
  pinMode(TRACK5, OUTPUT);
  digitalWrite(TRACK5, OFF);
 
/*
delay(1000);
digitalWrite(TRACK3, ON);delay(1000);
digitalWrite(TRACK4, ON);delay(1000);
digitalWrite(TRACK5, ON);delay(1000);
digitalWrite(TRACK6, ON);delay(1000);

digitalWrite(TRACK3, HIGH);
digitalWrite(TRACK4, HIGH);
digitalWrite(TRACK5, HIGH);
digitalWrite(TRACK6, HIGH);
delay(10000);
*/

  //SSID och Password till lokala nätverket, anslut
  WiFi.begin(STASSID, STAPSK);
  //analogWriteFreq(pwmfrq);
  long starttid = millis();
  while (WiFi.status() != WL_CONNECTED) {
    delay(200);
    Serial.print(".");
  }

  Udp.begin(localPort);
  Serial.println("Anslutet och startat!");
}

void loop() {

  //Check if there is UDP message to process
  getUDPdata();
  // 100ms repeat:
  if (millis() >= lastrun + 100) {
    lastrun = millis();

    //UpdATE THROTTLE SETTINGS
    if (1 == set_direction_a) analogWrite(CWA, throttle_speed_a);
    if (0 == set_direction_a) analogWrite(CCWA, throttle_speed_a);
    if (1 == set_direction_b) analogWrite(CWB, throttle_speed_b);
    if (0 == set_direction_b) analogWrite(CCWB, throttle_speed_b);


    //Update I/O settings
    if (0 == FunctionKey_a[0]) digitalWrite(TRACK3, OFF);
    if (1 == FunctionKey_a[0]) digitalWrite(TRACK3, ON);
    if (0 == FunctionKey_a[1]) digitalWrite(TRACK4, OFF);
    if (1 == FunctionKey_a[1]) digitalWrite(TRACK4, ON);
    if (0 == FunctionKey_b[0]) digitalWrite(TRACK5, OFF);
    if (1 == FunctionKey_b[0]) digitalWrite(TRACK5, ON);
    if (0 == FunctionKey_b[1]) digitalWrite(TRACK6, OFF);
    if (1 == FunctionKey_b[1]) digitalWrite(TRACK6, ON);
  }
}  // Slut loop
