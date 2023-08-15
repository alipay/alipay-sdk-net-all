using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionVersionQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionVersionQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }

        /// <summary>
        /// 云函数版本信息列表
        /// </summary>
        [XmlArray("versions")]
        [XmlArrayItem("version")]
        public List<Version> Versions { get; set; }
    }
}
