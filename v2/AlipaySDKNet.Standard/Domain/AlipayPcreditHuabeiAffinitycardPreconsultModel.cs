using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAffinitycardPreconsultModel : AopObject
    {
        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 支付宝用户2088账号
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 商户与支付宝签约的PID，从商户与支付宝签约的销售方案中获取
        /// </summary>
        [XmlElement("merchant_partner_id")]
        public string MerchantPartnerId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
