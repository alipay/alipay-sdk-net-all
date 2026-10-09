using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionQueryResponse : AopResponse
    {
        /// <summary>
        /// 云函数信息列表
        /// </summary>
        [XmlArray("functions")]
        [XmlArrayItem("function_m_o")]
        public List<FunctionMO> Functions { get; set; }

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
