using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyCommunityQueryResponse.
    /// </summary>
    public class AlipayCommercePropertyCommunityQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("community_info_v_o")]
        public List<CommunityInfoVO> List { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
