using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SharePeerPaySecurityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SharePeerPaySecurityInfo : AopObject
    {
        /// <summary>
        /// 来源应用
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 外部终端设备id
        /// </summary>
        [XmlElement("external_device_id")]
        public string ExternalDeviceId { get; set; }

        /// <summary>
        /// 终端类型 客户端-client/PC-pc/WAP-wap
        /// </summary>
        [XmlElement("terminal_type")]
        public string TerminalType { get; set; }
    }
}
