using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgUserQueryApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgUserQueryApiResponse : AopObject
    {
        /// <summary>
        /// 人脸id，可与userId只传一个
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 状态，1存在2不存在
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }

        /// <summary>
        /// 用户场景下唯一标示码
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
