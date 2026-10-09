using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUpdateInfoParam Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUpdateInfoParam : AopObject
    {
        /// <summary>
        /// 病种编码, 厂商自行维护
        /// </summary>
        [XmlElement("disease_code")]
        public string DiseaseCode { get; set; }

        /// <summary>
        /// 病种名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 是否医保商品
        /// </summary>
        [XmlElement("insurance")]
        public string Insurance { get; set; }

        /// <summary>
        /// 医保商品医保编码, 从医保部门获取
        /// </summary>
        [XmlElement("insurance_code")]
        public string InsuranceCode { get; set; }

        /// <summary>
        /// OMS厂商商品编码, 厂商自行维护
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// sku信息
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_update_info_param")]
        public List<SkuUpdateInfoParam> SkuList { get; set; }

        /// <summary>
        /// 商品上下架状态 当前字段已废弃(如需操作上下架请使用上下架接口)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品店内分类编码, 标准分类参照文档
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
