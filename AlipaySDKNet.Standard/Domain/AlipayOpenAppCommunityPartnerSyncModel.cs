using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCommunityPartnerSyncModel : AopObject
    {
        /// <summary>
        /// 操作类型(PUT/REMOVE)
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [XmlElement("rela_type")]
        public string RelaType { get; set; }

        /// <summary>
        /// 关系来源
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 源对象id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 目标对象列表
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("community_partner_relation_data_sync_d_t_o")]
        public List<CommunityPartnerRelationDataSyncDTO> TargetList { get; set; }
    }
}
