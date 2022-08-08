using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherBalanceRechargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherBalanceRechargeInfo : AopObject
    {
        /// <summary>
        /// 支付宝余额充值金额  限制：  1.币种为人民币，单位元。  2. 总预算=优惠金额*总发券张数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 出资的商户支付宝登录账号  限制:  logon_id和partner_id必须且只能二选一
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 出资的商户支付宝ID  限制:  logon_id和partner_id必须且只能二选一
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
