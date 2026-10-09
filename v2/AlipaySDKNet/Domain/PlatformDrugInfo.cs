using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformDrugInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformDrugInfo : AopObject
    {
        /// <summary>
        /// 剂型
        /// </summary>
        [XmlElement("dosage_form")]
        public string DosageForm { get; set; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [XmlElement("drug_generic_name")]
        public string DrugGenericName { get; set; }

        /// <summary>
        /// 药品id
        /// </summary>
        [XmlElement("drug_id")]
        public string DrugId { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("drug_name")]
        public string DrugName { get; set; }

        /// <summary>
        /// 药品图片链接
        /// </summary>
        [XmlElement("drug_url")]
        public string DrugUrl { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 药品数量
        /// </summary>
        [XmlElement("medicine_quantity")]
        public string MedicineQuantity { get; set; }

        /// <summary>
        /// 药品单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [XmlElement("spec")]
        public string Spec { get; set; }
    }
}
