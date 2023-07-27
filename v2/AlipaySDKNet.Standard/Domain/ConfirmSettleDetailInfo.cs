using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConfirmSettleDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConfirmSettleDetailInfo : AopObject
    {
        /// <summary>
        /// 仅当trans_in_type为userId时，返回脱敏的支付宝登录号。
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 本次确认结算的实际结算金额，单位为元。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 结算主体标识。当结算主体类型为SecondMerchant时，为二级商户的SecondMerchantID
        /// </summary>
        [XmlElement("settle_entity_id")]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型。  二级商户:SecondMerchant; 商户门店:Store; 直连商户:Partner
        /// </summary>
        [XmlElement("settle_entity_type")]
        public string SettleEntityType { get; set; }

        /// <summary>
        /// 当结算类型为cardAliasNo时返回结算卡编号； 当结算类型为userId时为脱敏的支付宝账号。
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 结算收款方的账户类型 cardAliasNo/userId。 cardAliasNo表示结算到银行卡； userId表示结算到支付宝账号
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }
    }
}
