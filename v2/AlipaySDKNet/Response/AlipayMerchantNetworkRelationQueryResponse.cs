using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantNetworkRelationQueryResponse.
    /// </summary>
    public class AlipayMerchantNetworkRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 父子关系
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }
    }
}
