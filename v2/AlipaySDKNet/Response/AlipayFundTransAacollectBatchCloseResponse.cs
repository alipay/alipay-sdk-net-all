using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCloseResponse.
    /// </summary>
    public class AlipayFundTransAacollectBatchCloseResponse : AopResponse
    {
        /// <summary>
        /// * 批次状态       * <p>       *      <b>一阶段模式:</b>       *      <pre>       *                                 ----> SUCCESS       *                              /       *                             /       *          INIT ----------> FIRST_STAGE---> PART_SUCCESS       *                             \       *                              \       *                               -----> FAIL       *      </pre>       * </p>
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }
    }
}
