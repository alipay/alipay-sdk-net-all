using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentConversationQueryResponse.
    /// </summary>
    public class AlipayCloudNextbuilderAgentConversationQueryResponse : AopResponse
    {
        /// <summary>
        /// 会话列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("nb_conversation")]
        public List<NbConversation> Data { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("pagination")]
        public NbPagination Pagination { get; set; }
    }
}
