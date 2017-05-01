﻿using System;

namespace Dragino.Radio.LoraWan.Network.Messages
{
    public class RxpkMessage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="time">UTC time of receipt of the LoRa frame.  The precision is one microsecond.  The format is ISO 8601 ‘compact’ format ( [3]).  The object is present only when the receiving gateway has a source of accurate time.</param>
        /// <param name="tmst">The value of the gateway internal time counter at the instant the LoRa frame was received, with microsecond granularity.  The value will rollover approximately every 72 minutes.   The timestamp values generated by different gateways are unrelated.</param>
        /// <param name="freq">The centre frequency of the received signal in units of MHz.</param>
        /// <param name="chan">Concentrator “IF” channel on which the frame was received.</param>
        /// <param name="rfch">Concentrator radio frequency chain on which the frame was received.</param>
        /// <param name="stat">The result of the gateway's CRC test on the frame.   x 1 = correct x -1 = incorrect x 0 = no CRC test was performed.</param>
        /// <param name="modu">The modulation technique used: x “LORA”, representing LoRa modulation x “FSK”, representing FSK modulation.</param>
        /// <param name="datr">Datarate identifier.   When "modu" equals "LORA", "datr" comprises "SFnBWm", where 'n' is an integer representing the frame's 'spreading factor' and 'm' is an integer representing the frame's bandwidth in units of kHz.   When "modu" equals "FSK" "datr" comprises an integer representing the frame's bit rate in Hz.</param>
        /// <param name="codr">ECC code rate.  "codr" comprises the string "k/n", where 'k' represents the carried bits and 'n' the total number of bits received, including those used by the error checking/correction algorithm.</param>
        /// <param name="rssi">The measured received signal strength in units of dBm.</param>
        /// <param name="lsnr">The measured received signal to noise ratio in units of dB.</param>
        /// <param name="size">The number of octets in the received frame.</param>
        /// <param name="data">The frame payload, encoded into Base64, [4]. The Base64 padding characters shall not be added.</param>
        public RxpkMessage(
            DateTime time,
            uint tmst,
            double freq,
            uint chan,
            uint rfch,
            int stat,
            string modu,
            string datr,
            string codr,
            int rssi,
            double lsnr,
            uint size,
            string data)
        {
            Time = time;
            Tmst = tmst;
            Freq = freq;
            Chan = chan;
            Rfch = rfch;
            Stat = stat;
            Modu = modu;
            Datr = datr;
            Codr = codr;
            Rssi = rssi;
            Lsnr = lsnr;
            Size = size;
            Data = data;
        }

        /// <summary>
        /// UTC time of receipt of the LoRa frame.  The precision is one microsecond.  The format is ISO 8601 ‘compact’ format ( [3]).  The object is present only when the receiving gateway has a source of accurate time.
        /// </summary>
        public DateTime Time { get; }

        /// <summary>
        /// The value of the gateway internal time counter at the instant the LoRa frame was received, with microsecond granularity.  The value will rollover approximately every 72 minutes.   The timestamp values generated by different gateways are unrelated.
        /// </summary>
        public uint Tmst { get; }

        /// <summary>
        /// The centre frequency of the received signal in units of MHz.
        /// </summary>
        public double Freq { get; }

        /// <summary>
        /// Concentrator “IF” channel on which the frame was received.
        /// </summary>
        public uint Chan { get; }

        /// <summary>
        /// Concentrator radio frequency chain on which the frame was received.
        /// </summary>
        public uint Rfch { get; }

        /// <summary>
        /// The result of the gateway's CRC test on the frame.   x 1 = correct x -1 = incorrect x 0 = no CRC test was performed.
        /// </summary>
        public int Stat { get; }

        /// <summary>
        /// The modulation technique used: x “LORA”, representing LoRa modulation x “FSK”, representing FSK modulation.
        /// </summary>
        public string Modu { get; }

        /// <summary>
        /// Datarate identifier.   When "modu" equals "LORA", "datr" comprises "SFnBWm", where 'n' is an integer representing the frame's 'spreading factor' and 'm' is an integer representing the frame's bandwidth in units of kHz.   When "modu" equals "FSK" "datr" comprises an integer representing the frame's bit rate in Hz.
        /// </summary>
        public string Datr { get; }

        /// <summary>
        /// ECC code rate.  "codr" comprises the string "k/n", where 'k' represents the carried bits and 'n' the total number of bits received, including those used by the error checking/correction algorithm.
        /// </summary>
        public string Codr { get; }

        /// <summary>
        /// The measured received signal strength in units of dBm.
        /// </summary>
        public int Rssi { get; }

        /// <summary>
        /// The measured received signal to noise ratio in units of dB.
        /// </summary>
        public double Lsnr { get; }

        /// <summary>
        /// The number of octets in the received frame.
        /// </summary>
        public uint Size { get; }

        /// <summary>
        /// The frame payload, encoded into Base64, [4]. The Base64 padding characters shall not be added.
        /// </summary>
        public string Data { get; }
    }
}