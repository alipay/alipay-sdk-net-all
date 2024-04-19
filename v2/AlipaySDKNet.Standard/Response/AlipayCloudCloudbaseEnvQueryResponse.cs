using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvQueryResponse : AopResponse
    {
        /// <summary>
        /// 环境信息列表
        /// </summary>
        [XmlArray("envs")]
        [XmlArrayItem("env")]
        public List<Env> Envs { get; set; }

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
