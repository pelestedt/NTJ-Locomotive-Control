/*
   Config.h

*/

/* Definition av IO signaler */

#define CWA D0    //
#define CCWA D1   //
#define CWB D5   //
#define CCWB D6   //
#define TRACK3 D3   //
#define TRACK4 D4   //
#define TRACK5 D7   //
#define TRACK6 D2   //

#define OFF HIGH
#define ON LOW



int Inaddr;

/* Define Control board I/O signals */
int throttle_speed_a = 0; //0 to 126
int throttle_speed_b = 0; //0 to 126
byte set_direction_a = 1; //1=forwrd 0=reverse
byte set_direction_b = 1; //1=forwrd 0=reverse
String namn;
byte FunctionKey_a[30];
byte FunctionKey_b[30];
int lastparamq=0;
unsigned long lastrun=0;

int DIRECTION;
int SPEED;
int Q;
int KEY;
int Funktionstangenter;

//getUDPdata declarations

String STASSID = "NTJ";
String STAPSK =  "NTJNTJ01";
int packetSize=0;

int myIDa = 111;
int myIDb = 222;

unsigned int localPort = 8888;      // local port to listen on
long lastparam1_a = 0;
long lastparam1_b = 0;

// buffer for sending data
char packetBuffer[20 + 1]; //buffer to hold incoming packet,

WiFiUDP Udp;

//Variabler lagrade i EEprom med defaultvärden angivna här
int pwmfrq = 10000;
