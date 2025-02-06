using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockPortfolioCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockPortfolioCheckModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 股票代码列表
        /// </summary>
        [XmlArray("symbol_list")]
        [XmlArrayItem("string")]
        public List<string> SymbolList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
