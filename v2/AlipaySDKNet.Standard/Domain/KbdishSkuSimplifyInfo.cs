using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishSkuSimplifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishSkuSimplifyInfo : AopObject
    {
        /// <summary>
        /// 加料组列表
        /// </summary>
        [XmlArray("material_group_list")]
        [XmlArrayItem("kbdish_material_simplify_info")]
        public List<KbdishMaterialSimplifyInfo> MaterialGroupList { get; set; }

        /// <summary>
        /// 外部skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 规格1组名称
        /// </summary>
        [XmlElement("spec_01_group_name")]
        public string Spec01GroupName { get; set; }

        /// <summary>
        /// 规格1的id
        /// </summary>
        [XmlElement("spec_01_id")]
        public string Spec01Id { get; set; }

        /// <summary>
        /// 规格1名称
        /// </summary>
        [XmlElement("spec_01_name")]
        public string Spec01Name { get; set; }

        /// <summary>
        /// 规格1排序值
        /// </summary>
        [XmlElement("spec_01_sort")]
        public string Spec01Sort { get; set; }

        /// <summary>
        /// 规格2组名称
        /// </summary>
        [XmlElement("spec_02_group_name")]
        public string Spec02GroupName { get; set; }

        /// <summary>
        /// 规格2的id
        /// </summary>
        [XmlElement("spec_02_id")]
        public string Spec02Id { get; set; }

        /// <summary>
        /// 规格2的名称
        /// </summary>
        [XmlElement("spec_02_name")]
        public string Spec02Name { get; set; }

        /// <summary>
        /// 规格2的排序值
        /// </summary>
        [XmlElement("spec_02_sort")]
        public string Spec02Sort { get; set; }
    }
}
