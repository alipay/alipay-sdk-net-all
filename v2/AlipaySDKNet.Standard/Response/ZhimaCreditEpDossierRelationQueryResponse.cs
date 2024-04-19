using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierRelationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierRelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 关联关系列表
        /// </summary>
        [XmlArray("relation_node_list")]
        [XmlArrayItem("relation_node_info")]
        public List<RelationNodeInfo> RelationNodeList { get; set; }
    }
}
