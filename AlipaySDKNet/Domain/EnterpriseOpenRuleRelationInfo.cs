using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseOpenRuleRelationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseOpenRuleRelationInfo : AopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 所有者id（企业情况下=enterpriseId）
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 费控制度id
        /// </summary>
        [XmlElement("standard_id")]
        public string StandardId { get; set; }
    }
}
