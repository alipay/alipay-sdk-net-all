using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockPortfolioQueryResponse.
    /// </summary>
    public class AntfortuneStockPortfolioQueryResponse : AopResponse
    {
        /// <summary>
        /// 自选股票标的列表
        /// </summary>
        [XmlArray("symbol_list")]
        [XmlArrayItem("string")]
        public List<string> SymbolList { get; set; }
    }
}
