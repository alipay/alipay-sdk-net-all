using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionLogQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionLogQueryResponse : AopResponse
    {
        /// <summary>
        /// 云函数执行日志记录
        /// </summary>
        [XmlArray("logs")]
        [XmlArrayItem("string")]
        public List<string> Logs { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
