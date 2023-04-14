using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WithdrawPrincipalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class WithdrawPrincipalDTO : AopObject
    {
        /// <summary>
        /// 可变ID
        /// </summary>
        [XmlElement("external_entity_id")]
        public string ExternalEntityId { get; set; }

        /// <summary>
        /// 商户定义的卡编号
        /// </summary>
        [XmlElement("partner_card_no")]
        public string PartnerCardNo { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 主体类型 SUB_MERCHANT_ALIPAY_ACC:二级商家绑定的支付宝余额账户, SUB_MERCHANT_BANKCARD:二级商家绑定的银行卡, ALIPAY_ACC:普通支付宝余额账户, BANKCARD:普通银行卡
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }
    }
}
