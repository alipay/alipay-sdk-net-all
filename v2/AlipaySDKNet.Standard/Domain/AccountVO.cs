using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountVO Data Structure.
    /// </summary>
    [Serializable]
    public class AccountVO : AopObject
    {
        /// <summary>
        /// 户名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 分类 BUYER付款账户； SELLER收款账户
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 上次支付失败
        /// </summary>
        [XmlElement("last_pay_fail")]
        public string LastPayFail { get; set; }

        /// <summary>
        /// 开户网点
        /// </summary>
        [XmlElement("offical_name")]
        public string OfficalName { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [XmlElement("offical_number")]
        public string OfficalNumber { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
