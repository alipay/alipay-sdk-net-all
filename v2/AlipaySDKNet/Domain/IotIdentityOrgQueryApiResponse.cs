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
        /// 业务人脸库id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 弹性人脸库id
        /// </summary>
        [XmlElement("logic_group_id")]
        public string LogicGroupId { get; set; }
    }
}
