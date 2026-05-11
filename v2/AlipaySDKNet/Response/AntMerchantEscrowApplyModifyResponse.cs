using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantEscrowApplyModifyResponse.
    /// </summary>
    public class AntMerchantEscrowApplyModifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝受理主单号
        /// </summary>
        [XmlElement("ant_merchant_order_no")]
        public string AntMerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝请求号
        /// </summary>
        [XmlElement("ant_merchant_request_id")]
        public string AntMerchantRequestId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
