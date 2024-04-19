using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteIndexpageQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteIndexpageQueryResponse : AopResponse
    {
        /// <summary>
        /// 索引文件名
        /// </summary>
        [XmlElement("index_file")]
        public string IndexFile { get; set; }
    }
}
