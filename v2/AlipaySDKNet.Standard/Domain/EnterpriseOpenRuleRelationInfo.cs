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
        /// 企业ID【推荐使用】
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

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
        /// 企业共同账户ID【不推荐使用】
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
