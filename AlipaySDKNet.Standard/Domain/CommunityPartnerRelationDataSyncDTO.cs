using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityPartnerRelationDataSyncDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityPartnerRelationDataSyncDTO : AopObject
    {
        /// <summary>
        /// 关系业务数据
        /// </summary>
        [XmlElement("rela_data")]
        public string RelaData { get; set; }

        /// <summary>
        /// 2020-06-06 06:06:06
        /// </summary>
        [XmlElement("rela_expire")]
        public string RelaExpire { get; set; }

        /// <summary>
        /// 关系状态
        /// </summary>
        [XmlElement("rela_status")]
        public string RelaStatus { get; set; }

        /// <summary>
        /// 目标对象id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
