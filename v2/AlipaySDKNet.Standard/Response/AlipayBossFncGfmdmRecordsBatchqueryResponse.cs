using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfmdmRecordsBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncGfmdmRecordsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 列表类型，包含多条records
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("md_record")]
        public List<MdRecord> ResultData { get; set; }

        /// <summary>
        /// 错误码对应的详细错误信息，助于排查问题
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
