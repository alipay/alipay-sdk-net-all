using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSmartcampusSportsrecordBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSmartcampusSportsrecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 运动记录列表
        /// </summary>
        [XmlArray("sports_record_list")]
        [XmlArrayItem("sports_tool_record")]
        public List<SportsToolRecord> SportsRecordList { get; set; }
    }
}
