using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitlelibraryListQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitlelibraryListQueryResponse : AopResponse
    {
        /// <summary>
        /// 抬头名称列表
        /// </summary>
        [XmlArray("title_name_list")]
        [XmlArrayItem("string")]
        public List<string> TitleNameList { get; set; }
    }
}
