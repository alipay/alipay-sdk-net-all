using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserUgshoppingRecommendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserUgshoppingRecommendQueryModel : AopObject
    {
        /// <summary>
        /// 渠道号
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("filter_item_ids")]
        [XmlArrayItem("string")]
        public List<string> FilterItemIds { get; set; }

        /// <summary>
        /// 开放平台用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 请求页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
