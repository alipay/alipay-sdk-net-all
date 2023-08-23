using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionExecutionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionExecutionQueryResponse : AopResponse
    {
        /// <summary>
        /// 云函数执行记录列表
        /// </summary>
        [XmlArray("executions")]
        [XmlArrayItem("execution")]
        public List<Execution> Executions { get; set; }

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
