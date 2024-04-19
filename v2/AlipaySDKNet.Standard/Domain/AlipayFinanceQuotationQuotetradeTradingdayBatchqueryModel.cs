using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeTradingdayBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeTradingdayBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询的开始日期, 格式为 yyyyMMdd
        /// </summary>
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 查询的结束日期, 日式为 yyyyMMdd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 市场, 查询该市场的交易日
        /// </summary>
        [XmlElement("market")]
        public string Market { get; set; }
    }
}
