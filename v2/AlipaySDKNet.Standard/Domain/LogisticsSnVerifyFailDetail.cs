using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsSnVerifyFailDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsSnVerifyFailDetail : AopObject
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("sn_id")]
        public string SnId { get; set; }
    }
}
