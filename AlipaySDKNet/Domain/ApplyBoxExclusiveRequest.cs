using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyBoxExclusiveRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyBoxExclusiveRequest : AopObject
    {
        /// <summary>
        /// 品牌box基础模型
        /// </summary>
        [XmlElement("base_info")]
        public BoxExclusiveBase BaseInfo { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 默认品牌触发词
        /// </summary>
        [XmlArray("default_keywords")]
        [XmlArrayItem("string")]
        public List<string> DefaultKeywords { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 自定义品牌触发词
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("string")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// box官方账号
        /// </summary>
        [XmlArray("related_accounts")]
        [XmlArrayItem("box_exclusive_service")]
        public List<BoxExclusiveService> RelatedAccounts { get; set; }

        /// <summary>
        /// box服务模型
        /// </summary>
        [XmlArray("related_functions")]
        [XmlArrayItem("box_exclusive_service")]
        public List<BoxExclusiveService> RelatedFunctions { get; set; }
    }
}
