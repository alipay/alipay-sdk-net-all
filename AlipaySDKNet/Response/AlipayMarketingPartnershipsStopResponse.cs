using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingPartnershipsStopResponse.
    /// </summary>
    public class AlipayMarketingPartnershipsStopResponse : AopResponse
    {
        /// <summary>
        /// 合作状态，枚举值： ESTABLISHED：已建立 TERMINATED：已终止
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 终止合作关系时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("stop_time")]
        public string StopTime { get; set; }
    }
}
