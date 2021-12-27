using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneUserSignResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneUserSignResponse : AopResponse
    {
        /// <summary>
        /// 支付宝为学生（教职工）生成的刷脸UID
        /// </summary>
        [XmlElement("face_user_id")]
        public string FaceUserId { get; set; }
    }
}
