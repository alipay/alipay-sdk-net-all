using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacepayCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacepayCloseModel : AopObject
    {
        /// <summary>
        /// 采集人脸学生uid
        /// </summary>
        [XmlElement("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 场景码: K12 COLLEGE
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 学生所在学校外标
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
