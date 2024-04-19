using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechCreateandpayResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 费用订单号
        /// </summary>
        [XmlElement("fee_order_no")]
        public string FeeOrderNo { get; set; }

        /// <summary>
        /// 动账支付时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
