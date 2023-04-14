using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaymentVoucherAlipayBalanceRechargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaymentVoucherAlipayBalanceRechargeInfo : AopObject
    {
        /// <summary>
        /// 出资的支付宝登录账号 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
