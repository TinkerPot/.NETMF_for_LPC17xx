using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine
{
    /// <summary>
    /// Defines the .Net Micro Framework transport type for device connection
    /// </summary>
    public enum TransportType
    {
        Serial,
        USB,
        TCPIP,
    }

    /// <summary>
    /// .Net Micro Framework serial port definition.  Defines characteristics of the serial port 
    /// for which a .Net Micro Framework may be attached.
    /// </summary>
    public class MFSerialPort : MFPortDefinition
    {
        public MFSerialPort(string name, string port)
        {
            m_name      = name;
            m_transport = TransportType.Serial;
            m_port      = port;
        }
    }

    /// <summary>
    /// .Net Micro Framework USB port definition.  Defines characteristics of the USB port 
    /// for which a .Net Micro Framework may be attached.
    /// </summary>
    public class MFUsbPort : MFPortDefinition
    {
        public MFUsbPort(string usbName)
        {
            m_name = usbName;
            m_transport = TransportType.USB;
            m_port = usbName;

            int idx = m_port.IndexOf("_");
            if (idx >= 0)
            {
                m_port = m_port.Substring(idx + 1, m_port.Length - idx - 1);
            }
        }
    }

    /// <summary>
    /// .Net Micro Framework TcpIp port definition.  Defines characteristics of the TcpIp port 
    /// for which a .Net Micro Framework may be attached.
    /// </summary>
    public class MFTcpIpPort : MFPortDefinition
    {
        internal IPAddress m_ipaddress;

        public MFTcpIpPort(string ipAddress, string mac)
        {
            m_name = ipAddress;

            if (mac.Trim().Length > 0)
            {
                m_name += " - (" + mac + ")";
            }
            m_transport = TransportType.TCPIP;
            m_port      = ipAddress;
            
            IPAddress.TryParse(m_name, out m_ipaddress);
        }

        public    IPAddress Address { get { return m_ipaddress; } }
    }

    /// <summary>
    /// Abstract base class for a .Net Micro Framework port definition class.
    /// </summary>
    public abstract class MFPortDefinition
    {
        internal TransportType m_transport;
        internal string m_name;
        internal string m_port;

        public string        Name        { get { return m_name;      } }
        public string        Port        { get { return m_port;      } }
        public TransportType Transport   { get { return m_transport; } }

        public override string ToString() { return m_name; }
    }
}
