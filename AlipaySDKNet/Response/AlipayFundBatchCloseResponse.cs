using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundBatchCloseResponse.
    /// </summary>
    public class AlipayFundBatchCloseResponse : AopResponse
    {
        /// <summary>
        /// 支付宝内部的批次ID
        /// </summary>
        [XmlElement("batch_trans_id")]
        public string BatchTransId { get; set; }

        /// <summary>
        /// DISUSE：批次废弃
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
