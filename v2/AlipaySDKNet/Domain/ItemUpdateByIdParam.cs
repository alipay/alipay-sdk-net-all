using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUpdateByIdParam Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUpdateByIdParam : AopObject
    {
        /// <summary>
        /// 病种编码, 厂商自行维护
        /// </summary>
        [XmlElement("disease_code")]
        public string DiseaseCode { get; set; }

        /// <summary>
        /// 病种名称,厂商自行维护
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
        /// 支付宝内部商品编码ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// sku信息
        /// </summary>
        [XmlArray("sku_list")]
        [XmlArrayItem("sku_update_by_code_param")]
        public List<SkuUpdateByCodeParam> SkuList { get; set; }

        /// <summary>
        /// 商品店内分类编码, 标准分类参照文档
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
