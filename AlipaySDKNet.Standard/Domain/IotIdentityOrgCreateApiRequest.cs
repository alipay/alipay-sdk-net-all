using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgCreateApiRequest Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgCreateApiRequest : AopObject
    {
        /// <summary>
        /// 人脸id
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }
    }
}
