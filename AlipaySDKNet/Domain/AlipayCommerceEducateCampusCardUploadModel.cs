using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusCardUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusCardUploadModel : AopObject
    {
        /// <summary>
        /// 学生证照片链接(可多张)。注：需要提供图片oss URL访问地址，且url需要长期有效
        /// </summary>
        [XmlArray("campus_card_picture")]
        [XmlArrayItem("string")]
        public List<string> CampusCardPicture { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }
    }
}
