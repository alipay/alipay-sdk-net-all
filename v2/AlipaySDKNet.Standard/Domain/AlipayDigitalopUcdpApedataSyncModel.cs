using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApedataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApedataSyncModel : AopObject
    {
        /// <summary>
        /// 内容数据的列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个模型只能选一个传，且单次列表数量不要超过100）
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("ape_content_item")]
        public List<ApeContentItem> ContentList { get; set; }

        /// <summary>
        /// 商品数据的列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个模型只能选一个传，且单次列表数量不要超过100）
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("ape_data_item")]
        public List<ApeDataItem> DataList { get; set; }

        /// <summary>
        /// 数据类型，可选值：USER（用户数据）、ITEM（商品数据）、BEHAVIOR（行为数据）
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 通用物品列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个模型只能选一个传，且单次列表数量不要超过100）
        /// </summary>
        [XmlArray("generic_item_list")]
        [XmlArrayItem("ape_generic_item")]
        public List<ApeGenericItem> GenericItemList { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 本地零售商品列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个模型只能选一个传，且单次列表数量不要超过100）
        /// </summary>
        [XmlArray("retail_item_list")]
        [XmlArrayItem("ape_retail_item")]
        public List<ApeRetailItem> RetailItemList { get; set; }
    }
}
