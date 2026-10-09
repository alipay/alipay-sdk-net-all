using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundIndustryPurchaseResponse.
    /// </summary>
    public class AlipayFundIndustryPurchaseResponse : AopResponse
    {
        /// <summary>
        /// 实际基金申购的金额（单位元），与入参一致
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 基金申购时间，与报送清算的时间保持一致
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 支付宝申购流水号。如果发生申购撤销，需要把这笔流水号从文件中带回来
        /// </summary>
        [XmlElement("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 入参携带的外部请求号，原样返回
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
