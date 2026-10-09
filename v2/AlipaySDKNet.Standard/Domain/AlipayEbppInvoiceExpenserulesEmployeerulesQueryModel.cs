using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesEmployeerulesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesEmployeerulesQueryModel : AopObject
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
        /// 未切换open_id时使用此字段：员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 切换open_id后使用此字段：员工的open_id
        /// </summary>
        [XmlElement("employee_open_id")]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 页码，默认值为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页行数，默认值为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
