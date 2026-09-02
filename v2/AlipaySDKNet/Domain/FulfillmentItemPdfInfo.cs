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
        /// 文件id，文件流OSS上传接口返回的fileId
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 商品ID集合
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("item_info_for_fulfillment_list")]
        public List<ItemInfoForFulfillmentList> ItemInfos { get; set; }

        /// <summary>
        /// pdf文件链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }
    }
}
