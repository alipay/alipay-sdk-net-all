using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundIndustryOperationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundIndustryOperationQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝流水号（fascore流水号） 支持申购、申购撤销、赎回等流水的查询
        /// </summary>
        [XmlElement("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 支付外部请求号 支持申购、赎回流水的查询
        /// </summary>
        [XmlElement("pay_out_request_no")]
        public string PayOutRequestNo { get; set; }

        /// <summary>
        /// 申购撤销流水的外部请求号 （查询申购撤销流水时，需要传入对应的申购单外部请求号/申购单支付宝流水号）
        /// </summary>
        [XmlElement("refund_out_request_no")]
        public string RefundOutRequestNo { get; set; }
    }
}
