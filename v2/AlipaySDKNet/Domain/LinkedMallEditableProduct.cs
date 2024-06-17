using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkedMallEditableProduct Data Structure.
    /// </summary>
    [Serializable]
    public class LinkedMallEditableProduct : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("desc_path")]
        public string DescPath { get; set; }

        /// <summary>
        /// 商品副图
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 商品主图链接
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
