using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingPartnershipsCreateResponse.
    /// </summary>
    public class AlipayMarketingPartnershipsCreateResponse : AopResponse
    {
        /// <summary>
        /// 建立合作关系的时间。格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 合作状态，枚举值： ESTABLISHED：已建立 TERMINATED：已终止
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
