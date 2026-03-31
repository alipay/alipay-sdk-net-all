using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeProductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeProductQueryModel : AopObject
    {
        /// <summary>
        /// 商品id，通过创建接口获取
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }
    }
}
