using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasItemModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasItemModifyModel : AopObject
    {
        /// <summary>
        /// 商品详情地址
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商品扩展信息：可以解析成 Map 的 json string
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        [XmlElement("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 前台类目id：target_type + target_id 和 front_category_id 二选一
        /// </summary>
        [XmlElement("front_category_id")]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品id(和external_item_id不能同时为空)
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("label_list")]
        [XmlArrayItem("fuel_item_label_create_info")]
        public List<FuelItemLabelCreateInfo> LabelList { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        [XmlElement("main_pic")]
        public string MainPic { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 更新时间戳（只处理时间戳最大的一次请求）
        /// </summary>
        [XmlElement("op_timestamp")]
        public long OpTimestamp { get; set; }

        /// <summary>
        /// 场景：GAS_CHARGE（加油）
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("fuel_item_sku_create_info")]
        public List<FuelItemSkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商品状态： EFFECT（有效）、 INVALID（无效）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
