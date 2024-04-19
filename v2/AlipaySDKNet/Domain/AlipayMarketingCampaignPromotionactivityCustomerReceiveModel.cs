using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityCustomerReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignPromotionactivityCustomerReceiveModel : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 风控字段apdid
        /// </summary>
        [XmlElement("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 手机端客户端的ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 商户的pid 例如2088301847277786
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 外部请求号，用来保证幂等性， 需要权益唯一。 建议用UUID。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
