using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 交易结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("consumption_end")]
        public string ConsumptionEnd { get; set; }

        /// <summary>
        /// 交易开始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("consumption_start")]
        public string ConsumptionStart { get; set; }

        /// <summary>
        /// 员工支付宝UID列表，单次传入最大员工数量为10
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 员工支付宝UID列表，单次传入最大员工数量为10
        /// </summary>
        [XmlArray("employee_open_ids")]
        [XmlArrayItem("string")]
        public List<string> EmployeeOpenIds { get; set; }
    }
}
