using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerQueryResponse.
    /// </summary>
    public class AlipayOpenAppCommunityPartnerQueryResponse : AopResponse
    {
        /// <summary>
        /// 关系数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 关系对象
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("community_partner_rela_data")]
        public List<CommunityPartnerRelaData> DataList { get; set; }
    }
}
