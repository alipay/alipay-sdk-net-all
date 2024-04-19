using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// HuanxuTradeOrderQueryResponse.
    /// </summary>
    public class HuanxuTradeOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付，打款或者退款的操作金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 聚合支付的支付渠道，焕旭分配。
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付、打款、退款时候焕旭返回的唯一凭证id，调用方查询时候建议优先传入该值，内部处理时优先以该值为准。instruction_id和out_request_no不能同时为空。
        /// </summary>
        [XmlElement("instruction_id")]
        public string InstructionId { get; set; }

        /// <summary>
        /// 指令类型，表明该笔查询是支付，打款还是退款，跟out_request_no一起使用。 支付：PAY 打款：DISBURSE 退款：REFUND
        /// </summary>
        [XmlElement("instruction_type")]
        public string InstructionType { get; set; }

        /// <summary>
        /// 支付、打款或退款请求号，out_request_no和instruction_id不能同时为空。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付，打款或者退款的状态，目前支持如下值： WAIT（指令操作已受理）； SUCCESS（指令操作成功）； FAIL（指令操作失败）。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
