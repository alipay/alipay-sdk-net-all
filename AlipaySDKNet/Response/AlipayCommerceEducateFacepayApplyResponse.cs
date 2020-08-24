using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacepayApplyResponse.
    /// </summary>
    public class AlipayCommerceEducateFacepayApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请token
        /// </summary>
        [XmlElement("apply_token")]
        public string ApplyToken { get; set; }

        /// <summary>
        /// 采集人脸学生uid
        /// </summary>
        [XmlElement("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 学生所在学校外标(国标码)
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
