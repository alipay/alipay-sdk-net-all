using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFDrugInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HDFDrugInfo : AopObject
    {
        /// <summary>
        /// 批准文号
        /// </summary>
        [XmlElement("approve_number")]
        public string ApproveNumber { get; set; }

        /// <summary>
        /// 用药时长
        /// </summary>
        [XmlElement("drug_duration")]
        public long DrugDuration { get; set; }

        /// <summary>
        /// 用药时长单位
        /// </summary>
        [XmlElement("drug_duration_unit")]
        public string DrugDurationUnit { get; set; }

        /// <summary>
        /// 用药频率
        /// </summary>
        [XmlElement("drug_frequency")]
        public string DrugFrequency { get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [XmlElement("drug_name")]
        public string DrugName { get; set; }

        /// <summary>
        /// 开药量
        /// </summary>
        [XmlElement("drug_quantity")]
        public long DrugQuantity { get; set; }

        /// <summary>
        /// 开药量单位
        /// </summary>
        [XmlElement("drug_quantity_unit")]
        public string DrugQuantityUnit { get; set; }

        /// <summary>
        /// 用药途径
        /// </summary>
        [XmlElement("drug_route")]
        public string DrugRoute { get; set; }

        /// <summary>
        /// 药品规格
        /// </summary>
        [XmlElement("drug_specification")]
        public string DrugSpecification { get; set; }

        /// <summary>
        /// 用药禁忌
        /// </summary>
        [XmlElement("drug_taboo")]
        public string DrugTaboo { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [XmlElement("factory")]
        public string Factory { get; set; }

        /// <summary>
        /// 单次用量
        /// </summary>
        [XmlElement("once_dosage")]
        public string OnceDosage { get; set; }

        /// <summary>
        /// 单次用量单位
        /// </summary>
        [XmlElement("once_dosage_unit")]
        public string OnceDosageUnit { get; set; }

        /// <summary>
        /// 合作方唯一药品标识 PARTNER_DRUG_888
        /// </summary>
        [XmlElement("partner_drug_id")]
        public string PartnerDrugId { get; set; }

        /// <summary>
        /// 药品商品名
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 是否为处方药 true  是/ false 否
        /// </summary>
        [XmlElement("rx")]
        public bool Rx { get; set; }

        /// <summary>
        /// 煎法/服用方法
        /// </summary>
        [XmlElement("take_mode")]
        public string TakeMode { get; set; }

        /// <summary>
        /// 用药时间
        /// </summary>
        [XmlElement("user_time")]
        public string UserTime { get; set; }
    }
}
