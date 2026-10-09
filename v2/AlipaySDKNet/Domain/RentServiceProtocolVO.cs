using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentServiceProtocolVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentServiceProtocolVO : AopObject
    {
        /// <summary>
        /// 租赁协议名称
        /// </summary>
        [XmlElement("protocol_name")]
        public string ProtocolName { get; set; }

        /// <summary>
        /// 租赁协议地址，小程序page路径
        /// </summary>
        [XmlElement("protocol_path")]
        public string ProtocolPath { get; set; }
    }
}
