using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockPortfolioCheckResponse.
    /// </summary>
    public class AntfortuneStockPortfolioCheckResponse : AopResponse
    {
        /// <summary>
        /// 在自选列表的标的
        /// </summary>
        [XmlArray("in_list")]
        [XmlArrayItem("string")]
        public List<string> InList { get; set; }

        /// <summary>
        /// 不在自选列表的标的
        /// </summary>
        [XmlArray("out_list")]
        [XmlArrayItem("string")]
        public List<string> OutList { get; set; }
    }
}
