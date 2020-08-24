using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsPkgauthrelationAuthtomeQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsPkgauthrelationAuthtomeQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权关系列表
        /// </summary>
        [XmlArray("pkg_auth_relations")]
        [XmlArrayItem("pkg_auth_relation")]
        public List<PkgAuthRelation> PkgAuthRelations { get; set; }
    }
}
