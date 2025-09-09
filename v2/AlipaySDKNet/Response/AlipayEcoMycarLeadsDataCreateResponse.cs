using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarLeadsDataCreateResponse.
    /// </summary>
    public class AlipayEcoMycarLeadsDataCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝线索id
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 线索生成时间 单位:年月日时分秒
        /// </summary>
        [XmlElement("leads_time")]
        public string LeadsTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部线索id
        /// </summary>
        [XmlElement("out_leads_id")]
        public string OutLeadsId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
