using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenTrendBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeopenTrendBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询最近{day}天的分时数据
        /// </summary>
        [XmlElement("day")]
        public string Day { get; set; }

        /// <summary>
        /// 非必传，用于增量查询，最早的分时点时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }

        /// <summary>
        /// 股票唯一编码，拼接规则：股票代码.股票市场
        /// </summary>
        [XmlArray("symbols")]
        [XmlArrayItem("string")]
        public List<string> Symbols { get; set; }
    }
}
