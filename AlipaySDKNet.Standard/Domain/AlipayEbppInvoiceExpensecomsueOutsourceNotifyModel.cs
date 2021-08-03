using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecomsueOutsourceNotifyModel : AopObject
    {
        /// <summary>
        /// 企业码账号
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消费金额（单位：分）
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 交易发生时间
        /// </summary>
        [XmlElement("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 0 员工支付宝账号，1 员工公司员工号
        /// </summary>
        [XmlElement("employee_id_type")]
        public long EmployeeIdType { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 0 是扣款，1 退款
        /// </summary>
        [XmlElement("is_off_set")]
        public long IsOffSet { get; set; }

        /// <summary>
        /// 外部唯一交易ID（幂等）
        /// </summary>
        [XmlElement("out_source_id")]
        public string OutSourceId { get; set; }

        /// <summary>
        /// 调用者身份（道安- DAO_AN）
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }
    }
}
