using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgQueryApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgQueryApiResponse : AopObject
    {
        /// <summary>
        /// 人脸库id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
