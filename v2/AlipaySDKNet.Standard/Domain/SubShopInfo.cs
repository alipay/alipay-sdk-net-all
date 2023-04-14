using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SubShopInfo : AopObject
    {
        /// <summary>
        /// 门店信息集合
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("shop")]
        public List<Shop> ShopList { get; set; }
    }
}
