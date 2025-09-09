using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsWorkOrderRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsWorkOrderRiskInfo : AopObject
    {
        /// <summary>
        /// 风控完成时间
        /// </summary>
        [XmlElement("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 风控失败原因，如果风控成功，该值为空
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }
    }
}
