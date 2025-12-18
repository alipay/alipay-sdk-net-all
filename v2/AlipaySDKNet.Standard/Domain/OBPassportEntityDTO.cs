using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OBPassportEntityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OBPassportEntityDTO : AopObject
    {
        /// <summary>
        /// 自然实体名称
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 个人:INDIVIDUAL 企业:COMPANY 机构:INSTITUTION
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 通行证ID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
