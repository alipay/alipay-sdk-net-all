using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUpdatedByIdFailVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUpdatedByIdFailVO : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商品平台id
        /// </summary>
        [XmlElement("source_item_id")]
        public string SourceItemId { get; set; }
    }
}
