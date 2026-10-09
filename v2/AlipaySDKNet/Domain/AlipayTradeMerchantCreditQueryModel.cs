using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeMerchantCreditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeMerchantCreditQueryModel : AopObject
    {
        /// <summary>
        /// 标识本次授信拆分的业务场景，具体的值由支付宝定义
        /// </summary>
        [XmlElement("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 标识商家授信额度的来源，具体的值由支付宝定义
        /// </summary>
        [XmlElement("merchant_credit_source")]
        public string MerchantCreditSource { get; set; }

        /// <summary>
        /// 商家授权开通账期的卖家userid
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }
    }
}
