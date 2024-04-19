using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextGroup Data Structure.
    /// </summary>
    [Serializable]
    public class TextGroup : AopObject
    {
        /// <summary>
        /// 价格优惠字段
        /// </summary>
        [XmlElement("discount_text")]
        public TextSource DiscountText { get; set; }

        /// <summary>
        /// 主文本信息List
        /// </summary>
        [XmlArray("main_text_list")]
        [XmlArrayItem("text_source")]
        public List<TextSource> MainTextList { get; set; }

        /// <summary>
        /// 副文本信息list
        /// </summary>
        [XmlArray("sub_text_list")]
        [XmlArrayItem("text_source")]
        public List<TextSource> SubTextList { get; set; }
    }
}
