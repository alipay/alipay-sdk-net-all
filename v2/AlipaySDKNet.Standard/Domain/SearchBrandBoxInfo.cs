using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBrandBoxInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBrandBoxInfo : AopObject
    {
        /// <summary>
        /// box基础信息
        /// </summary>
        [XmlElement("base_info")]
        public BoxExclusiveBase BaseInfo { get; set; }

        /// <summary>
        /// box状态
        /// </summary>
        [XmlElement("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// box类型
        /// </summary>
        [XmlElement("box_type")]
        public string BoxType { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 提报来源
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// box服务工单信息
        /// </summary>
        [XmlElement("functions_order_info")]
        public BoxOrderStatusInfo FunctionsOrderInfo { get; set; }

        /// <summary>
        /// 品牌触发词信息
        /// </summary>
        [XmlElement("keywords")]
        public BoxExclusiveKeyword Keywords { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 官方账号
        /// </summary>
        [XmlArray("related_accounts")]
        [XmlArrayItem("box_exclusive_service")]
        public List<BoxExclusiveService> RelatedAccounts { get; set; }

        /// <summary>
        /// 功能服务
        /// </summary>
        [XmlArray("related_functions")]
        [XmlArrayItem("box_exclusive_service")]
        public List<BoxExclusiveService> RelatedFunctions { get; set; }
    }
}
