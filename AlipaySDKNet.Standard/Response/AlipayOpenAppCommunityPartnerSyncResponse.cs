using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerSyncResponse.
    /// </summary>
    public class AlipayOpenAppCommunityPartnerSyncResponse : AopResponse
    {
        /// <summary>
        /// 目标对象数据
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("community_partner_relation_data_sync_d_t_o")]
        public List<CommunityPartnerRelationDataSyncDTO> TargetList { get; set; }
    }
}
