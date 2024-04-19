using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvAkQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvAkQueryResponse : AopResponse
    {
        /// <summary>
        /// ak对象集合
        /// </summary>
        [XmlArray("aks")]
        [XmlArrayItem("workspace_ak")]
        public List<WorkspaceAk> Aks { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
