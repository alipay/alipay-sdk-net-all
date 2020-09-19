using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemQueryResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("app_content_item")]
        public List<AppContentItem> Items { get; set; }

        /// <summary>
        /// 总商品数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
