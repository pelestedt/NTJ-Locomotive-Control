EESchema Schematic File Version 2
LIBS:power
LIBS:device
LIBS:switches
LIBS:Transistor_BJT
LIBS:relays
LIBS:Relay2
LIBS:motors
LIBS:transistors
LIBS:conn
LIBS:linear
LIBS:regul
LIBS:74xx
LIBS:cmos4000
LIBS:adc-dac
LIBS:memory
LIBS:xilinx
LIBS:microcontrollers
LIBS:dsp
LIBS:microchip
LIBS:analog_switches
LIBS:motorola
LIBS:texas
LIBS:intel
LIBS:audio
LIBS:interface
LIBS:digital-audio
LIBS:philips
LIBS:display
LIBS:cypress
LIBS:siliconi
LIBS:opto
LIBS:atmel
LIBS:contrib
LIBS:valves
LIBS:elec-unifil
LIBS:Diode_Bridge
LIBS:Lokstyrning-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 1
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
Wire Wire Line
	5700 2750 5700 3000
$Comp
L R R2
U 1 1 5ABCC270
P 5200 2950
F 0 "R2" V 5280 2950 50  0000 C CNN
F 1 "R" V 5200 2950 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 5130 2950 50  0001 C CNN
F 3 "" H 5200 2950 50  0001 C CNN
	1    5200 2950
	1    0    0    -1  
$EndComp
$Comp
L R R1
U 1 1 5ABCC2C1
P 4850 3200
F 0 "R1" V 4930 3200 50  0000 C CNN
F 1 "R" V 4850 3200 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 4780 3200 50  0001 C CNN
F 3 "" H 4850 3200 50  0001 C CNN
	1    4850 3200
	0    1    1    0   
$EndComp
Wire Wire Line
	5200 2800 5200 2750
Connection ~ 5200 2750
Wire Wire Line
	5200 3100 5200 3200
Wire Wire Line
	5000 3200 5400 3200
Connection ~ 5200 3200
$Comp
L Conn_01x08 J2
U 1 1 5ABCC525
P 6800 5250
F 0 "J2" H 6800 5650 50  0000 C CNN
F 1 "Conn_01x08" H 6800 4750 50  0000 C CNN
F 2 "Connectors_Molex:Molex_SPOX-5267_22-03-5085_08x2.54mm_Straight" H 6800 5250 50  0001 C CNN
F 3 "" H 6800 5250 50  0001 C CNN
	1    6800 5250
	1    0    0    -1  
$EndComp
Text GLabel 6000 5150 0    51   Input ~ 0
D1
Text GLabel 6000 5250 0    51   Input ~ 0
D2
Text GLabel 6000 5350 0    51   Input ~ 0
D3
Text GLabel 6000 5450 0    51   Input ~ 0
D4
Text GLabel 6000 5550 0    51   Input ~ 0
GND
Text GLabel 6000 5650 0    51   Input ~ 0
5V
$Comp
L Conn_01x08 J1
U 1 1 5ABCC6EB
P 6200 5250
F 0 "J1" H 6200 5650 50  0000 C CNN
F 1 "Conn_01x08" H 6200 4750 50  0000 C CNN
F 2 "Connectors_Molex:Molex_SPOX-5267_22-03-5085_08x2.54mm_Straight" H 6200 5250 50  0001 C CNN
F 3 "" H 6200 5250 50  0001 C CNN
	1    6200 5250
	1    0    0    -1  
$EndComp
Text GLabel 6600 5050 0    51   Input ~ 0
A0
Text GLabel 6600 5150 0    51   Input ~ 0
D0
Text GLabel 6600 5250 0    51   Input ~ 0
D5
Text GLabel 6600 5350 0    51   Input ~ 0
D6
Text GLabel 6600 5450 0    51   Input ~ 0
D7
Text GLabel 6600 5550 0    51   Input ~ 0
D8
Text GLabel 6600 5650 0    51   Input ~ 0
3,3V
Wire Wire Line
	6550 4950 6600 4950
Wire Wire Line
	6000 4950 5950 4950
Wire Wire Line
	5950 5050 6000 5050
$Comp
L ULN2803A U1
U 1 1 5ABCCAE9
P 3400 4350
F 0 "U1" H 3400 4875 50  0000 C CNN
F 1 "ULN2803A" H 3400 4800 50  0000 C CNN
F 2 "Package_DIP:DIP-18_W7.62mm_LongPads" H 3450 3700 50  0001 L CNN
F 3 "" H 3500 4250 50  0001 C CNN
	1    3400 4350
	1    0    0    -1  
$EndComp
Text GLabel 6450 3550 2    51   Input ~ 0
A0
Text GLabel 2850 4750 0    51   Input ~ 0
D1
Text GLabel 2850 4650 0    51   Input ~ 0
D2
Text GLabel 2850 4550 0    51   Input ~ 0
D3
Text GLabel 2850 4450 0    51   Input ~ 0
D4
Text GLabel 2850 4050 0    51   Input ~ 0
D5
Text GLabel 2850 4150 0    51   Input ~ 0
D6
Text GLabel 2850 4250 0    51   Input ~ 0
D7
Text GLabel 2850 4350 0    51   Input ~ 0
D8
Text GLabel 3400 5200 3    51   Input ~ 0
GND
Text GLabel 3950 4850 2    51   Input ~ 0
GND
Wire Wire Line
	2850 4050 3000 4050
Wire Wire Line
	2850 4150 3000 4150
Wire Wire Line
	2850 4250 3000 4250
Wire Wire Line
	2850 4350 3000 4350
Wire Wire Line
	2850 4450 3000 4450
Wire Wire Line
	2850 4550 3000 4550
Wire Wire Line
	2850 4650 3000 4650
Wire Wire Line
	2850 4750 3000 4750
Wire Wire Line
	3400 5050 3400 5200
Wire Wire Line
	3800 4850 3950 4850
Text GLabel 3950 4250 2    51   Input ~ 0
OUT3
Text GLabel 3950 4350 2    51   Input ~ 0
OUT4
Text GLabel 3950 4450 2    51   Input ~ 0
OUT5
Text GLabel 3950 4550 2    51   Input ~ 0
OUT6
Text GLabel 3950 4650 2    51   Input ~ 0
OUT7
Text GLabel 3950 4750 2    51   Input ~ 0
OUT8
Wire Wire Line
	3950 4250 3800 4250
Wire Wire Line
	3800 4350 3950 4350
Wire Wire Line
	3950 4450 3800 4450
Wire Wire Line
	3800 4550 3950 4550
Wire Wire Line
	3950 4650 3800 4650
Wire Wire Line
	3800 4750 3950 4750
$Comp
L LM7805_TO220 U2
U 1 1 5ABCD407
P 6700 2750
F 0 "U2" H 6550 2875 50  0000 C CNN
F 1 "LM7805_TO220" H 6700 2875 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-220_Vertical" H 6700 2975 50  0001 C CIN
F 3 "" H 6700 2700 50  0001 C CNN
	1    6700 2750
	1    0    0    -1  
$EndComp
Text GLabel 6700 3150 3    51   Input ~ 0
GND
Wire Wire Line
	6700 3050 6700 3150
Text GLabel 3300 2750 0    51   Output ~ 0
GND
Wire Wire Line
	3550 2750 3300 2750
$Comp
L POT RV1
U 1 1 5ABCD511
P 6150 3550
F 0 "RV1" V 5975 3550 50  0000 C CNN
F 1 "POT" V 6050 3550 50  0000 C CNN
F 2 "Potentiometers:Potentiometer_Trimmer_ACP_CA14h5_Vertical_Px5.0mm_Py10.0mm" H 6150 3550 50  0001 C CNN
F 3 "" H 6150 3550 50  0001 C CNN
	1    6150 3550
	1    0    0    -1  
$EndComp
Wire Wire Line
	6450 3550 6300 3550
Wire Wire Line
	5700 3400 7150 3400
Text GLabel 6150 3850 3    51   Input ~ 0
GND
Wire Wire Line
	6150 3700 6150 3850
Connection ~ 5700 2750
Text GLabel 7150 2750 2    51   Output ~ 0
5V
Wire Wire Line
	7150 2750 7000 2750
Text GLabel 7550 3350 0    51   Input ~ 0
OUT2
Wire Wire Line
	7550 3350 7700 3350
Text GLabel 8550 3350 2    51   Input ~ 0
5V
Wire Wire Line
	8550 3350 8300 3350
Text GLabel 7550 4150 0    51   Input ~ 0
GND
Wire Wire Line
	7700 4150 7550 4150
Wire Wire Line
	7150 3400 7150 3750
Wire Wire Line
	7150 3750 7700 3750
Connection ~ 6150 3400
Wire Wire Line
	8300 3650 9050 3650
Wire Wire Line
	9050 3650 9050 4650
Wire Wire Line
	8300 3850 8550 3850
Wire Wire Line
	8550 3850 8550 4050
Connection ~ 8550 4050
Wire Wire Line
	8750 3650 8700 3650
Connection ~ 8700 3650
Wire Wire Line
	8700 3650 8700 4250
Wire Wire Line
	8700 4250 8300 4250
$Comp
L LED D5
U 1 1 5ABCE098
P 5850 4500
F 0 "D5" H 5850 4600 50  0000 C CNN
F 1 "LED" H 5850 4400 50  0000 C CNN
F 2 "LEDs:LED_D3.0mm" H 5850 4500 50  0001 C CNN
F 3 "" H 5850 4500 50  0001 C CNN
	1    5850 4500
	-1   0    0    1   
$EndComp
$Comp
L R R3
U 1 1 5ABCE211
P 6250 4500
F 0 "R3" V 6330 4500 50  0000 C CNN
F 1 "R" V 6250 4500 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 6180 4500 50  0001 C CNN
F 3 "" H 6250 4500 50  0001 C CNN
	1    6250 4500
	0    1    1    0   
$EndComp
Wire Wire Line
	6100 4500 6000 4500
Text GLabel 6550 4500 2    51   Input ~ 0
D0
Wire Wire Line
	6550 4500 6400 4500
Wire Wire Line
	5550 4500 5700 4500
Text GLabel 9250 5050 0    51   Input ~ 0
OUT3
Text GLabel 9250 5150 0    51   Input ~ 0
OUT4
Text GLabel 9250 5250 0    51   Input ~ 0
OUT5
Text GLabel 9250 5350 0    51   Input ~ 0
OUT6
Text GLabel 9250 5450 0    51   Input ~ 0
OUT7
Text GLabel 9250 5550 0    51   Input ~ 0
OUT8
NoConn ~ 6550 4950
NoConn ~ 5950 4950
Wire Wire Line
	3850 2450 3850 2150
Wire Wire Line
	3850 2150 9150 2150
Wire Wire Line
	9150 2150 9150 4550
Wire Wire Line
	2950 3050 2950 2050
Wire Wire Line
	2950 2050 9250 2050
Wire Wire Line
	9250 2050 9250 4450
Wire Wire Line
	7050 2800 7050 2750
Connection ~ 7050 2750
Wire Wire Line
	6200 3100 7050 3100
Wire Wire Line
	6200 2750 6200 2800
Connection ~ 6200 2750
Connection ~ 3850 2450
Connection ~ 3550 3050
Connection ~ 3550 2750
Connection ~ 4150 2750
Connection ~ 6700 3100
Connection ~ 6400 2750
Connection ~ 3400 5050
$Comp
L TIP42 Q1
U 1 1 5ABD0E8B
P 5600 3200
F 0 "Q1" H 5850 3275 50  0000 L CNN
F 1 "TIP42" H 5850 3200 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-220_Vertical" H 5850 3125 50  0001 L CIN
F 3 "" H 5600 3200 50  0001 L CNN
	1    5600 3200
	1    0    0    1   
$EndComp
Text GLabel 5550 4500 0    51   Input ~ 0
3,3V
$Comp
L Screw_Terminal_01x12 J3
U 1 1 5BADEFCD
P 9450 4950
F 0 "J3" H 9450 5550 50  0000 C CNN
F 1 "Screw_Terminal_01x12" H 9450 4250 50  0000 C CNN
F 2 "Connectors_WAGO:WAGO_734_12Pin_Straight_RuggedPads" H 9450 4950 50  0001 C CNN
F 3 "" H 9450 4950 50  0001 C CNN
	1    9450 4950
	1    0    0    -1  
$EndComp
Wire Wire Line
	9150 4550 9250 4550
Wire Wire Line
	9050 4650 9250 4650
Wire Wire Line
	8900 4050 8900 4750
Wire Wire Line
	8900 4750 9250 4750
Wire Wire Line
	8900 4050 8300 4050
NoConn ~ 5950 5050
Text GLabel 4400 2750 2    60   Output ~ 0
VCC
Wire Wire Line
	4400 2750 4150 2750
Text GLabel 5100 2750 0    60   Input ~ 0
VCC
Wire Wire Line
	5100 2750 6400 2750
Wire Wire Line
	4400 3200 4700 3200
Wire Wire Line
	4400 4050 4400 3200
Wire Wire Line
	3800 4050 4400 4050
Text GLabel 3950 4150 2    51   Input ~ 0
OUT2
Wire Wire Line
	3950 4150 3800 4150
$Comp
L CP C1
U 1 1 5BB35120
P 6200 2950
F 0 "C1" H 6225 3050 50  0000 L CNN
F 1 "330u" H 6225 2850 50  0000 L CNN
F 2 "Capacitors_THT:CP_Radial_D8.0mm_P5.00mm" H 6238 2800 50  0001 C CNN
F 3 "" H 6200 2950 50  0001 C CNN
	1    6200 2950
	1    0    0    -1  
$EndComp
$Comp
L CP C2
U 1 1 5BB3516E
P 7050 2950
F 0 "C2" H 7075 3050 50  0000 L CNN
F 1 "330u" H 7075 2850 50  0000 L CNN
F 2 "Capacitors_THT:CP_Radial_D8.0mm_P5.00mm" H 7088 2800 50  0001 C CNN
F 3 "" H 7050 2950 50  0001 C CNN
	1    7050 2950
	1    0    0    -1  
$EndComp
Text GLabel 9150 4850 0    51   Input ~ 0
5V
Wire Wire Line
	9250 4850 9150 4850
$Comp
L KBU4B DB1
U 1 1 5BB366FA
P 3850 2750
F 0 "DB1" H 3950 3025 50  0000 L CNN
F 1 "KBU4B" H 3950 2950 50  0000 L CNN
F 2 "Diode_THT:Diode_Bridge_Vishay_KBU" H 4000 2875 50  0001 L CNN
F 3 "" H 3850 2750 50  0001 C CNN
	1    3850 2750
	1    0    0    -1  
$EndComp
Wire Wire Line
	3850 3050 2950 3050
Text GLabel 9150 4950 0    51   Input ~ 0
5V
Wire Wire Line
	9250 4950 9150 4950
$Comp
L G5V-2 K1
U 1 1 5BB3788E
P 8000 3750
F 0 "K1" H 8650 3900 50  0000 L CNN
F 1 "DS2Y-S-5vdc" H 8650 3800 50  0000 L CNN
F 2 ".pretty:Relay_SPST_OMRON-G5Q" H 8650 3700 50  0001 L CNN
F 3 "" H 7800 3750 50  0001 C CNN
	1    8000 3750
	0    1    1    0   
$EndComp
$EndSCHEMATC