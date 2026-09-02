using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneRoutehubApplyResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphoneRoutehubApplyResponse : AopResponse
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 运营商侧订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 签约绑定响应明细
        /// </summary>
        [XmlElement("sign_apply_result")]
        public SignApplyResult SignApplyResult { get; set; }
    }
}
