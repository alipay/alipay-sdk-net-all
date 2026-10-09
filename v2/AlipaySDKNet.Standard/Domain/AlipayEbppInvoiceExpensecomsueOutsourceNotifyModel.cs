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
        /// 企业共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 消费金额
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
        /// 员工账号类型
        /// </summary>
        [XmlElement("employee_id_type")]
        public long EmployeeIdType { get; set; }

        /// <summary>
        /// 员工开放id
        /// </summary>
        [XmlElement("employee_open_id")]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("is_off_set")]
        public long IsOffSet { get; set; }

        /// <summary>
        /// 外部交易支付单号
        /// </summary>
        [XmlElement("out_source_id")]
        public string OutSourceId { get; set; }

        /// <summary>
        /// 外部平台编码
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 外部交易退款单号
        /// </summary>
        [XmlElement("relate_no")]
        public string RelateNo { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
