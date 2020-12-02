using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CampusCardPicture Data Structure.
    /// </summary>
    [Serializable]
    public class CampusCardPicture : AopObject
    {
        /// <summary>
        /// 枚举类型：内页（1）、外页 （2）、录取通知书（3）
        /// </summary>
        [XmlElement("picture_type")]
        public string PictureType { get; set; }

        /// <summary>
        /// 学生证照片链接，注：需要提供图片oss URL访问地址，且url需要长期有效
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
