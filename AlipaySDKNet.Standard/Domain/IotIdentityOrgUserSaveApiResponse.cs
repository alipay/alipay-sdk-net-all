using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgUserSaveApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgUserSaveApiResponse : AopObject
    {
        /// <summary>
        /// 人脸id
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }
    }
}
