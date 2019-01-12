using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Managers
{
    public static class LoRa_Constants
    {
        public enum RadioMessageType // 5 bit
        {
            //Requests
            DATA_CHANNEL_REQUEST = 0,
            DEVICE_INFORMATION_REQUEST = 1,
            OPERATIONAL_REQUEST = 2,
            PING_MESSAGE = 3,
            DATA_CHANNEL_RESPONSE = 4,
            DEVICE_INFORMATION_RESPONSE = 5,
            OPERATIONAL_RESPONSE = 6,
            PONG_MESSAGE = 7,

            DISCOVER_NEIGHBOUR_REQUEST = 8,
            DISCOVER_NEIGHBOUR_RESPONSE = 9,

            UNCATEGORIZED_UNREL_MSG_REQUEST = 10,

            UNCATEGORIZED_REL_MSG_REQUEST = 11,
            UNCATEGORIZED_REL_MSG_RESPONSE = 12,

            ECHO_MESSAGE_REQUEST = 13,
            ECHO_MESSAGE_RESPONSE = 14,

            RADIO_MESSAGE_TYPE_COUNT = 15
        };


        public enum RadioServiceType
        {
            UNICAST_SERVICE = 0x00,
            MULTICAST_SERVICE = 0x01,
            BROADCAST_SERVICE = 0x02,
            RADIO_SERVICE_TYPE_COUNT = 0x03
        };

        public enum RadioRoutingHeaderType
        {
            UNICAST_DIRECT_HEADER = 0x00,
            UNICAST_ROUTED_HEADER = 0x01,
            MULTICAST_DIRECT_HEADER = 0x02,
            MULTICAST_ROUTED_HEADER = 0x03,
            BROADCAST_HEADER = 0x04,
            ROUTING_HEADER_TYPES_COUNT = 0x05
        };


        public enum DeviceChannelTypes
        {
            BME280_TEMPERATURE = 0,
            BME280_HUMIDITY = 1,
            BME280_AIR_PRESSURE = 2,
            BME280_ALTITUDE = 3,

            MAX31865_1_TEMPERATURE = 4,
            MAX31865_2_TEMPERATURE = 5,

            GPS_LONGTITUDE = 6,
            GPS_LATITUDE = 7,

            INA219_SUPPLY_CURRENT = 8,
            INA219_SOLAR_CURRENT = 9
        };

        public static readonly Dictionary<DeviceChannelTypes, string> DeviceChannelsDict = new Dictionary<DeviceChannelTypes, string>
        {
            { DeviceChannelTypes.BME280_TEMPERATURE, "BME280_TEMPERATURE" },
            { DeviceChannelTypes.BME280_HUMIDITY, "BME280_HUMIDITY" },
            { DeviceChannelTypes.BME280_AIR_PRESSURE, "BME280_AIR_PRESSURE" },
            { DeviceChannelTypes.BME280_ALTITUDE, "BME280_ALTITUDE" },

            { DeviceChannelTypes.MAX31865_1_TEMPERATURE, "MAX31865_1_TEMPERATURE" },
            { DeviceChannelTypes.MAX31865_2_TEMPERATURE, "MAX31865_2_TEMPERATURE" },

            { DeviceChannelTypes.GPS_LONGTITUDE, "GPS_LONGTITUDE" },
            { DeviceChannelTypes.GPS_LATITUDE, "GPS_LATITUDE" },

            { DeviceChannelTypes.INA219_SOLAR_CURRENT, "INA219_SOLAR_CURRENT" },
            { DeviceChannelTypes.INA219_SUPPLY_CURRENT, "INA219_SUPPLY_CURRENT" }
        };


        public static string[] channelsType = new string[]
        {
            "DIGITAL INPUT",
            "DIGITAL OUTPUT",
            "ANALOG INPUT",
            "ANALOG OUTPUT"
        };
        public static string[] dataTypes = new string[]
        {
            "S16_TYPE",
            "U16_TYPE",
            "FLOAT_TYPE",
            "BIT_TYPE "
        };

        public enum DeviceChannelStatus
        {
            SUCCESS = 0,
            DEVICE_NOT_EXIST = 1,
            ALARM = 2
        }
    }
}
