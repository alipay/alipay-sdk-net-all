using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExaminationSpuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExaminationSpuInfo : AopObject
    {
        /// <summary>
        /// 组合品标识
        /// </summary>
        [XmlElement("combination_product")]
        public string CombinationProduct { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 履约方描述
        /// </summary>
        [XmlElement("fulfillment_desc")]
        public string FulfillmentDesc { get; set; }

        /// <summary>
        /// 履约方类型
        /// </summary>
        [XmlElement("fulfillment_type")]
        public string FulfillmentType { get; set; }

        /// <summary>
        /// 主要指标
        /// </summary>
        [XmlElement("indicators")]
        public string Indicators { get; set; }

        /// <summary>
        /// 最高价格 单位人民币元
        /// </summary>
        [XmlElement("max_price")]
        public string MaxPrice { get; set; }

        /// <summary>
        /// 最低价格 单位人民币元
        /// </summary>
        [XmlElement("min_price")]
        public string MinPrice { get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [XmlElement("notice_info")]
        public string NoticeInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("package_items")]
        [XmlArrayItem("examination_package_item")]
        public List<ExaminationPackageItem> PackageItems { get; set; }

        /// <summary>
        /// 价格 单位人民币元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 项目说明
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 标品ID
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 标品标题
        /// </summary>
        [XmlElement("spu_title")]
        public string SpuTitle { get; set; }

        /// <summary>
        /// 履约方编码
        /// </summary>
        [XmlElement("vendor_code")]
        public string VendorCode { get; set; }
    }
}
