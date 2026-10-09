using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseIntentionBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceCareerOpenbaseIntentionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("batch_details")]
        [XmlArrayItem("career_open_base_intention_ladar_detail_result")]
        public List<CareerOpenBaseIntentionLadarDetailResult> BatchDetails { get; set; }

        /// <summary>
        /// 平台生成的批次号。
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次处理状态。
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 外部批次号
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }
    }
}
