using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShopAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShopAccountQueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("trade_no_list")]
        [XmlArrayItem("string")]
        public List<string> TradeNoList { get; set; }
    }
}
