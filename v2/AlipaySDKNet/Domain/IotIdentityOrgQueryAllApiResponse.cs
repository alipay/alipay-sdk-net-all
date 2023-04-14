using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotIdentityOrgQueryAllApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class IotIdentityOrgQueryAllApiResponse : AopObject
    {
        /// <summary>
        /// 签约主体外标id，机构或机构集id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 签约主体名称
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 签约主体类型，1机构2机构集
        /// </summary>
        [XmlElement("entity_type")]
        public long EntityType { get; set; }

        /// <summary>
        /// 人脸库id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
