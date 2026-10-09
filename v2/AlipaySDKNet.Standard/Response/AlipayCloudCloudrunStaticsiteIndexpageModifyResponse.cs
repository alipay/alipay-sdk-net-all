using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteIndexpageModifyResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteIndexpageModifyResponse : AopResponse
    {
        /// <summary>
        /// 本次变更成功的域名列表
        /// </summary>
        [XmlArray("domain_list")]
        [XmlArrayItem("string")]
        public List<string> DomainList { get; set; }

        /// <summary>
        /// 索引文件名
        /// </summary>
        [XmlElement("index_file")]
        public string IndexFile { get; set; }
    }
}
