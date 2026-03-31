using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantEscrowApplyResponse.
    /// </summary>
    public class AntMerchantEscrowApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝受理单号，基于商户+外部请求号做唯一性校验
        /// </summary>
        [XmlElement("ant_merchant_order_no")]
        public string AntMerchantOrderNo { get; set; }

        /// <summary>
        /// 发起商户入驻签约申请的外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
