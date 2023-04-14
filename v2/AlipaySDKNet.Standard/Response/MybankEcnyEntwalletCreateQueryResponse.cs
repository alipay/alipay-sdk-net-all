using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyEntwalletCreateQueryResponse.
    /// </summary>
    public class MybankEcnyEntwalletCreateQueryResponse : AopResponse
    {
        /// <summary>
        /// 外部请求号，受理成功时必填
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 受理流水号，受理成功时必填
        /// </summary>
        [XmlElement("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 钱包开立状态：PROCESSING-处理中；WAIT_VERIFY-意愿确认；SUCCESS-成功；FAIL-失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 钱包ID，钱包开立成功时必填
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
