using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmImplusChatrecordBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmImplusChatrecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分页参数，如果为空，则没有下一页
        /// </summary>
        [XmlElement("next")]
        public string Next { get; set; }

        /// <summary>
        /// 聊天记录
        /// </summary>
        [XmlArray("rows")]
        [XmlArrayItem("string")]
        public List<string> Rows { get; set; }
    }
}
