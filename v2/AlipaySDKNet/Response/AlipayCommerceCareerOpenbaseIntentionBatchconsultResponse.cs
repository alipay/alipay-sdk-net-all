using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseIntentionBatchconsultResponse.
    /// </summary>
    public class AlipayCommerceCareerOpenbaseIntentionBatchconsultResponse : AopResponse
    {
        /// <summary>
        /// 意向雷达平台生成的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 意向雷达批次处理状态。
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 调用方传入的外部批次号
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }
    }
}
