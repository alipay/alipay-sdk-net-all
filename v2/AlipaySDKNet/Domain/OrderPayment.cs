using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderPayment Data Structure.
    /// </summary>
    [Serializable]
    public class OrderPayment : AopObject
    {
        /// <summary>
        /// 企业资金账户ID
        /// </summary>
        [XmlElement("company_account_id")]
        public string CompanyAccountId { get; set; }

        /// <summary>
        /// 支付金额（元，两位小数）
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付宝账单号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付状态信息
        /// </summary>
        [XmlElement("pay_status_message")]
        public string PayStatusMessage { get; set; }

        /// <summary>
        /// 用于标记收款人支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("payee_open_id")]
        public string PayeeOpenId { get; set; }

        /// <summary>
        /// 收款人用户ID
        /// </summary>
        [XmlElement("payee_user_id")]
        public string PayeeUserId { get; set; }
    }
}
