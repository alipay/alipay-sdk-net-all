using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudNextbuilderAgentMessageQueryResponse.
    /// </summary>
    public class AlipayCloudNextbuilderAgentMessageQueryResponse : AopResponse
    {
        /// <summary>
        /// 消息列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("nb_message")]
        public List<NbMessage> Data { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("pagination")]
        public NbPagination Pagination { get; set; }
    }
}
