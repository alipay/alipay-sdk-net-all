using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolutionRecordQueryResponse.
    /// </summary>
    public class AlipayMerchantSolutionRecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 入参中的查询数据
        /// </summary>
        [XmlArray("record_data")]
        [XmlArrayItem("alipay_solution_record")]
        public List<AlipaySolutionRecord> RecordData { get; set; }

        /// <summary>
        /// 标识当前记录的审核状态
        /// </summary>
        [XmlElement("record_status_code")]
        public string RecordStatusCode { get; set; }

        /// <summary>
        /// 当前记录审核状态的中文描述
        /// </summary>
        [XmlElement("record_status_desc")]
        public string RecordStatusDesc { get; set; }

        /// <summary>
        /// 标识唯一的解决方案
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
