using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppFlowModeQueryResponse.
    /// </summary>
    public class AlipayEbppFlowModeQueryResponse : AopResponse
    {
        /// <summary>
        /// 抽奖活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 业务方上送手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 流量产品编码
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
