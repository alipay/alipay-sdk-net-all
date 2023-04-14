using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HealthDrugCatalogueItem Data Structure.
    /// </summary>
    [Serializable]
    public class HealthDrugCatalogueItem : AopObject
    {
        /// <summary>
        /// 是否是目录内药品
        /// </summary>
        [XmlElement("catalogue_listed")]
        public bool CatalogueListed { get; set; }

        /// <summary>
        /// 剂型
        /// </summary>
        [XmlElement("dosage_forms")]
        public string DosageForms { get; set; }

        /// <summary>
        /// 药品分类
        /// </summary>
        [XmlElement("drug_classification")]
        public string DrugClassification { get; set; }

        /// <summary>
        /// 处方药、非处方药的分类标识
        /// </summary>
        [XmlElement("drug_type")]
        public string DrugType { get; set; }

        /// <summary>
        /// 药品通用名
        /// </summary>
        [XmlElement("general_name")]
        public string GeneralName { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [XmlElement("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 药品商品名
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 生产厂家名称
        /// </summary>
        [XmlElement("manufacturer_name")]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// 最大可购买数量，如果为空则不限制
        /// </summary>
        [XmlElement("max_purchase_quantity")]
        public long MaxPurchaseQuantity { get; set; }

        /// <summary>
        /// 最小可购买数量，如果为空则不限制
        /// </summary>
        [XmlElement("min_purchase_quantity")]
        public long MinPurchaseQuantity { get; set; }

        /// <summary>
        /// 国药准字
        /// </summary>
        [XmlElement("national_medicine_permission_no")]
        public string NationalMedicinePermissionNo { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [XmlElement("specifications")]
        public string Specifications { get; set; }

        /// <summary>
        /// 支持急诊配送
        /// </summary>
        [XmlElement("support_emergency_delivery")]
        public bool SupportEmergencyDelivery { get; set; }

        /// <summary>
        /// 用法用量
        /// </summary>
        [XmlElement("usage_dosage")]
        public string UsageDosage { get; set; }
    }
}
