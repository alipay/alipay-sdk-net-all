using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenTradeperiodBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeopenTradeperiodBatchqueryModel : AopObject
    {
        /// <summary>
        /// 市场[_类型[_子类型]]. 如 SH, SH_ES, SH_ES_ASH
        /// </summary>
        [XmlElement("mkt_type_subtype")]
        public string MktTypeSubtype { get; set; }

        /// <summary>
        /// 请求时间范围
        /// </summary>
        [XmlElement("query_range")]
        public TradingQueryRange QueryRange { get; set; }

        /// <summary>
        /// 是否包含交易时间段
        /// </summary>
        [XmlElement("with_stages")]
        public bool WithStages { get; set; }

        /// <summary>
        /// 是否包含非交易日
        /// </summary>
        [XmlElement("with_untradings")]
        public bool WithUntradings { get; set; }
    }
}
