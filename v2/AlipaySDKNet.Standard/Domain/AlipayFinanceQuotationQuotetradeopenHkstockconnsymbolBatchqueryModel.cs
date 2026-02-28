using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenHkstockconnsymbolBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeopenHkstockconnsymbolBatchqueryModel : AopObject
    {
        /// <summary>
        /// 表示支持港股通的市场类型，沪港通合深港通
        /// </summary>
        [XmlArray("conn_types")]
        [XmlArrayItem("string")]
        public List<string> ConnTypes { get; set; }

        /// <summary>
        /// 分页查询条件
        /// </summary>
        [XmlElement("page_cond")]
        public PageCond PageCond { get; set; }

        /// <summary>
        /// 港股通股票标的
        /// </summary>
        [XmlArray("symbols")]
        [XmlArrayItem("string")]
        public List<string> Symbols { get; set; }
    }
}
