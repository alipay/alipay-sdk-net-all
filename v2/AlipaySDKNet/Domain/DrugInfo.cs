using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrugInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DrugInfo : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 诊断结果
        /// </summary>
        [XmlElement("diagnosis")]
        public string Diagnosis { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [XmlElement("drug_cnt")]
        public string DrugCnt { get; set; }

        /// <summary>
        /// 发药剂型
        /// </summary>
        [XmlElement("drug_dosform")]
        public string DrugDosform { get; set; }

        /// <summary>
        /// 药品图片链接
        /// </summary>
        [XmlElement("drug_pic_url")]
        public string DrugPicUrl { get; set; }

        /// <summary>
        /// 药品类型 1-处方药,2-OTC (西药必传）
        /// </summary>
        [XmlElement("drug_type")]
        public string DrugType { get; set; }

        /// <summary>
        /// 购买单位描述
        /// </summary>
        [XmlElement("drug_unit_desc")]
        public string DrugUnitDesc { get; set; }

        /// <summary>
        /// 外部药品编码
        /// </summary>
        [XmlElement("ext_drug_code")]
        public string ExtDrugCode { get; set; }

        /// <summary>
        /// 外部药品名称
        /// </summary>
        [XmlElement("ext_drug_name")]
        public string ExtDrugName { get; set; }

        /// <summary>
        /// 通用名
        /// </summary>
        [XmlElement("generic_name")]
        public string GenericName { get; set; }

        /// <summary>
        /// 规格  例：75mg*30粒
        /// </summary>
        [XmlElement("spec")]
        public string Spec { get; set; }

        /// <summary>
        /// 用法用量描述
        /// </summary>
        [XmlElement("usage_dosage_desc")]
        public string UsageDosageDesc { get; set; }
    }
}
