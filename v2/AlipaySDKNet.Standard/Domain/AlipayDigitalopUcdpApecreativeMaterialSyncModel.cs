using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeMaterialSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApecreativeMaterialSyncModel : AopObject
    {
        /// <summary>
        /// 创意组id,如果不填，重新创建一个创意组，如果填了 在原有的创意组中更新信息
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 创意组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 商品的素材信息
        /// </summary>
        [XmlArray("item_material_list")]
        [XmlArrayItem("ape_item_material")]
        public List<ApeItemMaterial> ItemMaterialList { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
