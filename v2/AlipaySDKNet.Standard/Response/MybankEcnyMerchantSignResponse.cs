using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyMerchantSignResponse.
    /// </summary>
    public class MybankEcnyMerchantSignResponse : AopResponse
    {
        /// <summary>
        /// 商户ID，签约成功时必填
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 受理流水号，受理成功时必填
        /// </summary>
        [XmlElement("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 签约状态：PROCESSING-处理中；SUCCESS-成功；FAIL-失败，受理成功时必填
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
