using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentItemPdfInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentItemPdfInfo : AopObject
    {
        /// <summary>
        /// 商品ID集合
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// pdf文件链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }
    }
}
