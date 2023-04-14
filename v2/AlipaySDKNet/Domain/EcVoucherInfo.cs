using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcVoucherInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcVoucherInfo : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 员工ID，汇总发票该字段无效
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 凭证内容
        /// </summary>
        [XmlElement("voucher_content")]
        public string VoucherContent { get; set; }

        /// <summary>
        /// 凭证创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("voucher_date")]
        public string VoucherDate { get; set; }

        /// <summary>
        /// 凭证ID，幂等用
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 凭证来源
        /// </summary>
        [XmlElement("voucher_source")]
        public string VoucherSource { get; set; }

        /// <summary>
        /// 凭证类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
