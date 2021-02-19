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
        /// 逐步废弃，请使用card_pictures字段！学生证照片链接(可多张)。注：需要提供图片oss URL访问地址，且url需要长期有效
        /// </summary>
        [XmlArray("campus_card_picture")]
        [XmlArrayItem("string")]
        public List<string> CampusCardPicture { get; set; }

        /// <summary>
        /// 学生证图片链接list，包含图片类型
        /// </summary>
        [XmlArray("card_pictures")]
        [XmlArrayItem("campus_card_picture")]
        public List<CampusCardPicture> CardPictures { get; set; }

        /// <summary>
        /// 学历，枚举类型：专科0，本科1，研究生2，博士3
        /// </summary>
        [XmlElement("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 入学时间，格式yyyy-mm-dd，不传无法自动机器审核
        /// </summary>
        [XmlElement("enroll_date")]
        public string EnrollDate { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }
    }
}
