using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvIndustrylogPrintModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvIndustrylogPrintModel : AopObject
    {
        /// <summary>
        /// 不同业务类型
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 日志内容
        /// </summary>
        [XmlElement("log_content")]
        public string LogContent { get; set; }
    }
}
