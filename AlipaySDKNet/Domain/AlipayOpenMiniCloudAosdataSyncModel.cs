using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniCloudAosdataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniCloudAosdataSyncModel : AopObject
    {
        /// <summary>
        /// 内容数据的列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个模型只能选一个传，且单次列表数量不要超过100）
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("content_item")]
        public List<ContentItem> ContentList { get; set; }

        /// <summary>
        /// 数据类型，可选值：GOODS（商品类数据），CONTENT（内容类数据），RETAIL（本地生活类数据），GENERIC（通用物品数据）
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 通用物品列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个模型只能选一个传，且单次列表数量不要超过100)
        /// </summary>
        [XmlArray("generic_item_list")]
        [XmlArrayItem("generic_item")]
        public List<GenericItem> GenericItemList { get; set; }

        /// <summary>
        /// 商品数据的列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个列表类型只能选一个传，且单次列表数量不要超过100
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("good_item")]
        public List<GoodItem> GoodsList { get; set; }

        /// <summary>
        /// 商家在小程序智能搜索引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public long ProjectId { get; set; }

        /// <summary>
        /// 本地零售商品列表（商品列表，内容列表，本地零售商品列表，通用物品列表，四个模型只能选一个传，且单次列表数量不要超过100）
        /// </summary>
        [XmlArray("retail_item_list")]
        [XmlArrayItem("retail_item")]
        public List<RetailItem> RetailItemList { get; set; }
    }
}
