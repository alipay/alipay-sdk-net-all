using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineTagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineTagInfo : AopObject
    {
        /// <summary>
        /// ["满20减2","两件9折"]
        /// </summary>
        [XmlArray("tag_text")]
        [XmlArrayItem("string")]
        public List<string> TagText { get; set; }

        /// <summary>
        /// PROMOTION_TAG - 促销标签(如: 满20减2) FEATURE_TAG - 功能标签(如: 24小时营业) DELIVERY_TAG - 配送标签(如: 美团专送)
        /// </summary>
        [XmlElement("tag_type")]
        public string TagType { get; set; }
    }
}
