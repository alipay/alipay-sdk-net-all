using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObDumpresultQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunObDumpresultQueryResponse : AopResponse
    {
        /// <summary>
        /// list为任务列表，totalCount为任务总数
        /// </summary>
        [XmlElement("dump_page_res")]
        public DumpPageRes DumpPageRes { get; set; }
    }
}
