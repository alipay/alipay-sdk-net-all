using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayInstEquitySendResult Data Structure.
    /// </summary>
    [Serializable]
    public class PayInstEquitySendResult : AopObject
    {
        /// <summary>
        /// 发放权益的活动ID
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 结果描述，详情参考结果码描述内容
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 发放成功后生成的发放凭证号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }
    }
}
