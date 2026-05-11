using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierRelData Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierRelData : AopObject
    {
        /// <summary>
        /// 蚂蚁原材料ID
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 蚂蚁原材料名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 二级供应商ID
        /// </summary>
        [XmlElement("out_supplier_id")]
        public string OutSupplierId { get; set; }

        /// <summary>
        /// 二级供应商名称
        /// </summary>
        [XmlElement("out_supplier_name")]
        public string OutSupplierName { get; set; }

        /// <summary>
        /// 整机供应商原材料ID
        /// </summary>
        [XmlElement("supplier_material_id")]
        public string SupplierMaterialId { get; set; }

        /// <summary>
        /// 整机供应商原材料名称
        /// </summary>
        [XmlElement("supplier_material_name")]
        public string SupplierMaterialName { get; set; }
    }
}
