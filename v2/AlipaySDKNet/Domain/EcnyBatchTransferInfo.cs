using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcnyBatchTransferInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcnyBatchTransferInfo : AopObject
    {
        /// <summary>
        /// 金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 失败原因，转账失败时必填
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 支付时间，转账成功时必填
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 转账备注，不可使用特殊字符，如 /，=，& ，<，>等
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 网商银行订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求方订单号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 状态，枚举值：INIT-处理中，SUCCESS-交易成功，FAIL-交易失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
