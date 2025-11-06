using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseInvoiceinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEnterpriseInvoiceinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 发票日期查询结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 报销状态：REIMBURSE_WAIT：待报销；REIMBURSE_APPLY：报销已提交；REIMBURSE_FINISH：报销完成
        /// </summary>
        [XmlArray("reimburse_status_list")]
        [XmlArrayItem("string")]
        public List<string> ReimburseStatusList { get; set; }

        /// <summary>
        /// 发票日期查询起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
