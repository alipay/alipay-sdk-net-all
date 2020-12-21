using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishDetailInfo : AopObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [XmlElement("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部sku_id列表
        /// </summary>
        [XmlArray("out_sku_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutSkuIdList { get; set; }
    }
}
