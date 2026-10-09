using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemUpdatedByCodeFailVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemUpdatedByCodeFailVO : AopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 原商品code
        /// </summary>
        [XmlElement("source_item_code")]
        public string SourceItemCode { get; set; }
    }
}
