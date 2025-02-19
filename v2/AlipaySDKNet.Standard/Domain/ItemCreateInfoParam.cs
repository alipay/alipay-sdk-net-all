using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemCreateInfoParam Data Structure.
    /// </summary>
    [Serializable]
    public class ItemCreateInfoParam : AopObject
    {
        /// <summary>
        /// 是否为医保商品, 0不是, 1是, 默认1
        /// </summary>
        [XmlElement("insurance")]
        public string Insurance { get; set; }

        /// <summary>
        /// 医保商品医保编码, 从国家医保目录获取
        /// </summary>
        [XmlElement("insurance_code")]
        public string InsuranceCode { get; set; }

        /// <summary>
        /// OMS厂商商品编码, 用于标识门店范围唯一一个商品, 厂商自行维护
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// sku信息
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_create_info_param")]
        public List<SkuCreateInfoParam> SkuList { get; set; }

        /// <summary>
        /// 商品上下架状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品供应链类型
        /// </summary>
        [XmlElement("supply_chain_type")]
        public string SupplyChainType { get; set; }

        /// <summary>
        /// 商品店内分类编码, 标准分类参照文档
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
