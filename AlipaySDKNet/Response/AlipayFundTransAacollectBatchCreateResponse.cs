using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCreateResponse.
    /// </summary>
    public class AlipayFundTransAacollectBatchCreateResponse : AopResponse
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次随机batchToken
        /// </summary>
        [XmlElement("batch_token")]
        public string BatchToken { get; set; }
    }
}
