using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbVirtualShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbVirtualShopInfo : AopObject
    {
        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlArray("catetory_list")]
        [XmlArrayItem("kbdish_virtual_category_info")]
        public List<KbdishVirtualCategoryInfo> CatetoryList { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
