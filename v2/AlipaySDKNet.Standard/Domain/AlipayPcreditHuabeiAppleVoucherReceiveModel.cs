using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAppleVoucherReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAppleVoucherReceiveModel : AopObject
    {
        /// <summary>
        /// 不同活动传不同活动id
        /// </summary>
        [XmlElement("amount_activity_id")]
        public string AmountActivityId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户id，政策给出
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 场景标识
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
