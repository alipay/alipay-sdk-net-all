using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolutionBatchSubmitResponse.
    /// </summary>
    public class AlipayMerchantSolutionBatchSubmitResponse : AopResponse
    {
        /// <summary>
        /// 提交成功后，在支付宝侧生成的批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
