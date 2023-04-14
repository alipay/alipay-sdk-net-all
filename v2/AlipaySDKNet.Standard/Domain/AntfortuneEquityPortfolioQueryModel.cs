using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneEquityPortfolioQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneEquityPortfolioQueryModel : AopObject
    {
        /// <summary>
        /// 组合Code
        /// </summary>
        [XmlElement("portfolio_code")]
        public string PortfolioCode { get; set; }

        /// <summary>
        /// 组合ID，已废弃，请使用组合Code参数查询
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
