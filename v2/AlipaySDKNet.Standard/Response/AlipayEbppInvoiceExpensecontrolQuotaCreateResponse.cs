using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolQuotaCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpensecontrolQuotaCreateResponse : AopResponse
    {
        /// <summary>
        /// 发放批次id
        /// </summary>
        [XmlElement("issue_batch_id")]
        public string IssueBatchId { get; set; }

        /// <summary>
        /// 额度发放明细检查错误列表，可根据报错信息修改发放明细列表
        /// </summary>
        [XmlArray("issue_quota_check_failed_list")]
        [XmlArrayItem("issue_quota_check_info")]
        public List<IssueQuotaCheckInfo> IssueQuotaCheckFailedList { get; set; }

        /// <summary>
        /// 创建的额度ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }
    }
}
