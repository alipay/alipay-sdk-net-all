using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallEditableSku Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallEditableSku : AopObject
    {
        /// <summary>
        /// sku图片链接
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
