using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionArgumentQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionArgumentQueryResponse : AopResponse
    {
        /// <summary>
        /// 参数配置列表
        /// </summary>
        [XmlArray("arguments")]
        [XmlArrayItem("argument")]
        public List<Argument> Arguments { get; set; }

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
        public string Total { get; set; }
    }
}
