using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplierCoreMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierCoreMaterialInfo : AopObject
    {
        /// <summary>
        /// 核心原材料id
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 核心原材料名称
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 备料周期，单位天
        /// </summary>
        [XmlElement("produce_period")]
        public long ProducePeriod { get; set; }

        /// <summary>
        /// 关联的物料ID列表
        /// </summary>
        [XmlArray("relation_item_list")]
        [XmlArrayItem("core_material_item_relation")]
        public List<CoreMaterialItemRelation> RelationItemList { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [XmlElement("specs")]
        public string Specs { get; set; }

        /// <summary>
        /// 子类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
