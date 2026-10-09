using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetGroupbudgetBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncAntbudgetGroupbudgetBatchqueryModel : AopObject
    {
        /// <summary>
        /// 财年，例如：2021
        /// </summary>
        [XmlElement("budget_fy")]
        public string BudgetFy { get; set; }

        /// <summary>
        /// ps部门信息
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 集团预算编码(提供精确查询)
        /// </summary>
        [XmlElement("group_budget_code")]
        public string GroupBudgetCode { get; set; }

        /// <summary>
        /// 操作人员工号，例如：286579（代表黑骑）
        /// </summary>
        [XmlElement("operator_work_no")]
        public string OperatorWorkNo { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
