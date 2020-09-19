using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishVirtualShopSimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishVirtualShopSimplifyInfo : AopObject
    {
        /// <summary>
        /// 门店下虚拟类目信息
        /// </summary>
        [XmlArray("catetory_list")]
        [XmlArrayItem("kbdish_virtual_catetory_simplify_info")]
        public List<KbdishVirtualCatetorySimplifyInfo> CatetoryList { get; set; }

        /// <summary>
        /// 外部门店id，和shop_id做为二选一必填
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
