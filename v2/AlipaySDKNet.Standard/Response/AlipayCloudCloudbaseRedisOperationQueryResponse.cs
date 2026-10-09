using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseRedisOperationQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseRedisOperationQueryResponse : AopResponse
    {
        /// <summary>
        /// 缓存任务列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("operation_list")]
        public List<OperationList> Data { get; set; }
    }
}
