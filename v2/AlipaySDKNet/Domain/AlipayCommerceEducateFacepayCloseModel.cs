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
        /// 刷脸用户openId
        /// </summary>
        [XmlElement("face_open_id")]
        public string FaceOpenId { get; set; }

        /// <summary>
        /// 刷脸用户id
        /// </summary>
        [XmlElement("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 场景码: K12 COLLEGE
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
