using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarGoodsIdsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarGoodsIdsSyncModel : AopObject
    {
        /// <summary>
        /// 商品库商品ID集合
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }
    }
}
