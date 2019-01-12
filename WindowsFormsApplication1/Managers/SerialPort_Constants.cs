using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Managers
{
    public static class SerialPort_Constants
    {
        public const ushort INCOMING_CMD_DEVICE_CONNECTING_REQUEST = 0;
        public const ushort OUTGOING_CMD_DEVICE_CONNECTING_RESPONSE = 1;

        public const ushort INCOMING_CMD_DEVICE_UNIQUE_ID_SET_REQUEST = 2;
        public const ushort INCOMING_CMD_DEVICE_UNIQUE_ID_GET_REQUEST = 3;
        public const ushort OUTGOING_CMD_DEVICE_UNIQUE_ID_RESPONSE = 4;


        public const ushort INCOMING_CMD_DEVICE_LORA_ID_SET_REQUEST = 5;

        public const ushort INCOMING_CMD_DEVICE_LORA_ID_GET_REQUEST = 6;

        public const ushort OUTGOING_CMD_DEVICE_LORA_ID_RESPONSE = 7;


        public const ushort INCOMING_CMD_DEVICE_LORA_GATEWAY_ID_SET_REQUEST = 8;

        public const ushort INCOMING_CMD_DEVICE_LORA_GATEWAY_ID_GET_REQUEST = 9;

        public const ushort OUTGOING_CMD_DEVICE_LORA_GATEWAY_ID_RESPONSE = 10;

        /*LORA CONFIGS */
        public const ushort INCOMING_CMD_LORA_CODING_RATE_SET_REQUEST = 11;
        public const ushort INCOMING_CMD_LORA_CODING_RATE_GET_REQUEST = 12;
        public const ushort OUTGOING_CMD_LORA_CODING_RATE_RESPONSE = 13;

        public const ushort INCOMING_CMD_LORA_BANDWIDTH_SET_REQUEST = 14;
        public const ushort INCOMING_CMD_LORA_BANDWIDTH_GET_REQUEST = 15;
        public const ushort OUTGOING_CMD_LORA_BANDWIDTH_RESPONSE = 16;

	    public const ushort INCOMING_CMD_LORA_SPREADING_FACTOR_SET_REQUEST = 17;
	    public const ushort INCOMING_CMD_LORA_SPREADING_FACTOR_GET_REQUEST = 18;
	    public const ushort OUTGOING_CMD_LORA_SPREADING_FACTOR_RESPONSE = 19;

	    public const ushort INCOMING_CMD_LORA_FREQUENCY_SET_REQUEST = 20;
	    public const ushort INCOMING_CMD_LORA_FREQUENCY_GET_REQUEST = 21;
	    public const ushort OUTGOING_CMD_LORA_FREQUENCY_RESPONSE = 22;

	    public const ushort INCOMING_CMD_LORA_TX_POWER_SET_REQUEST = 23;
	    public const ushort INCOMING_CMD_LORA_TX_POWER_GET_REQUEST = 24;
	    public const ushort OUTGOING_CMD_LORA_TX_POWER_RESPONSE = 25;

	    public const ushort INCOMING_CMD_LORA_CONFIG_SET_REQUEST = 26;
	    public const ushort INCOMING_CMD_LORA_CONFIG_GET_REQUEST = 27;
	    public const ushort OUTGOING_CMD_LORA_CONFIG_RESPONSE = 28;

        /* ECHO MONITORS */
        public const ushort INCOMING_CMD_LORA_ECHO_MONITOR_SET_REQUEST = 29;
        public const ushort INCOMING_CMD_LORA_ECHO_MONITOR_GET_REQUEST = 30;
        public const ushort OUTGOING_CMD_LORA_ECHO_MONITOR_REPONSE = 31;

	    /* ROUTING TABLE */
	    public const ushort INCOMING_CMD_LORA_STATIC_ROUTING_TABLE_SET_REQUEST = 35;
	    public const ushort INCOMING_CMD_LORA_STATIC_ROUTING_TABLE_GET_REQUEST = 36;
	    public const ushort OUTGOING_CMD_LORA_STATIC_ROUTING_TABLE_RESPONSE = 37;

        /* NEIGHBOUR_LIST */
        public const ushort INCOMING_CMD_NEIGHBOUR_LIST_GET_REQUEST = 38;
        public const ushort OUTGOING_CMD_NEIGHBOUR_LIST_RESPONSE = 39;
                
	    /* OPERATIONAL CODES */
	    public const ushort INCOMING_CMD_READ_MAX31865_REQUEST = 40;
	    public const ushort OUTGOING_CMD_READ_MAX31865_RESPONSE = 41;

	    public const ushort INCOMING_CMD_READ_BME280_REQUEST = 42;
	    public const ushort OUTGOING_CMD_READ_BME280_RESPONSE = 43;

	    public const ushort INCOMING_CMD_LORA_SEND_PACKAGE_REQUEST = 44;
	    public const ushort OUTGOING_CMD_LORA_RECEIVED_PACKAGE = 45;

	    public const ushort INCOMING_CMD_BLUETOOTH_NAME_SET_REQUEST = 66;
	    public const ushort INCOMING_CMD_BLUETOOTH_NAME_GET_REQUEST = 67;
	    public const ushort OUTGOING_CMD_BLUETOOTH_NAME_RESPONSE = 68;

	    /* STORAGE */
	    public const ushort INCOMING_CMD_FILENAMES_GET_REQUEST = 73;
	    public const ushort OUTGOUNG_CMD_FILENAMES_RESPONSE = 74;

	    /*DATE-TIME SETTING */
	    public const ushort INCOMING_CMD_DATE_SET_REQUEST = 100;
	    public const ushort INCOMING_CMD_DATE_GET_REQUEST = 101;
	    public const ushort OUTGOING_CMD_DATE_RESPONSE = 102;

	    public const ushort INCOMING_CMD_TIME_SET_REQUEST = 103;
	    public const ushort INCOMING_CMD_TIME_GET_REQUEST = 104;
	    public const ushort OUTGOING_CMD_TIME_RESPONSE = 	105;


        /* GPS */
        public const ushort INCOMING_CMD_GET_GPS_LOCATION_REQUEST = 120;
        public const ushort INCOMING_CMD_SYNC_WITH_GPS_TIME = 121;
        public const ushort OUTGOING_CMD_GPS_LOCATION_RESPONSE = 122;

        public const ushort INCOMING_CMD_SET_GPS_GGA_PERIOD_REQUEST = 123;
        public const ushort INCOMING_CMD_GET_GPS_GGA_PERIOD_REQUEST = 124;
        public const ushort OUTGOING_CMD_GPS_GGA_PERIOD_RESPONSE = 125;

	   public const ushort OUTGOING_CMD_ACK = 	400;
    }
}
