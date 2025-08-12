using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCstrainingUserdataQueryResponse.
    /// </summary>
    public class AlipayIserviceCstrainingUserdataQueryResponse : AopResponse
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
        /// 结果数据
        /// </summary>
        [XmlElement("result_list")]
        public string ResultList { get; set; }

        /// <summary>
        /// 总共数据数量
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
