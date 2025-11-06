using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCstrainingUserdatapageQueryResponse.
    /// </summary>
    public class AlipayIserviceCstrainingUserdatapageQueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页数据的条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("string")]
        public List<string> ResultList { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
