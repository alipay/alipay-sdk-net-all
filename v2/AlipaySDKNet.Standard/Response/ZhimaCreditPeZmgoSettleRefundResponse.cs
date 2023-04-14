using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoSettleRefundResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoSettleRefundResponse : AopResponse
    {
        /// <summary>
        /// 退款操作错误原因描述
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次请求退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 芝麻GO退款生成的内部唯一流水，外部商户可以拿这个参数进行对账
        /// </summary>
        [XmlElement("refund_opt_no")]
        public string RefundOptNo { get; set; }

        /// <summary>
        /// 此字段含义，商家接入时需咨询对接技术。
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 本次退款的扣款计划单号
        /// </summary>
        [XmlElement("withhold_plan_no")]
        public string WithholdPlanNo { get; set; }
    }
}
