using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImageTemplateData Data Structure.
    /// </summary>
    [Serializable]
    public class ImageTemplateData : AopObject
    {
        /// <summary>
        /// 图片高度
        /// </summary>
        [XmlElement("h")]
        public string H { get; set; }

        /// <summary>
        /// 图片的url地址
        /// </summary>
        [XmlElement("i")]
        public string I { get; set; }

        /// <summary>
        /// 原图大小
        /// </summary>
        [XmlElement("s")]
        public string S { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [XmlElement("w")]
        public string W { get; set; }
    }
}
