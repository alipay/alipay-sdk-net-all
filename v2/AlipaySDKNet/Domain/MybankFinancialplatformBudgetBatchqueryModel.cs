using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankFinancialplatformBudgetBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankFinancialplatformBudgetBatchqueryModel : AopObject
    {
        /// <summary>
        /// PURCHASE("PURCHASE", "采购")
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作者，不可为空，域账号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 分页页数，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
