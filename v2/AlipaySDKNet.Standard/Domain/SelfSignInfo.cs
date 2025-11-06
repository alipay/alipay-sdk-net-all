using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SelfSignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SelfSignInfo : AopObject
    {
        /// <summary>
        /// 签名值
        /// </summary>
        [XmlElement("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public long TimeStamp { get; set; }

        /// <summary>
        /// verifyMethod唯一标识
        /// </summary>
        [XmlElement("vm_id")]
        public string VmId { get; set; }
    }
}
