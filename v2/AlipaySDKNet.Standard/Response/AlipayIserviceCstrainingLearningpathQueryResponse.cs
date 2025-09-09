using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCstrainingLearningpathQueryResponse.
    /// </summary>
    public class AlipayIserviceCstrainingLearningpathQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("string")]
        public List<string> ResultList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
