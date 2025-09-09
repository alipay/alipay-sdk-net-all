using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSearchboxStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSearchboxStatusModifyModel : AopObject
    {
        /// <summary>
        /// 类目ID,建议长度控制在 128 字符之内
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商户生效渠道
        /// </summary>
        [XmlArray("client_type")]
        [XmlArrayItem("string")]
        public List<string> ClientType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 修改类型
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 目标状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
