using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabillsumQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabillsumQueryResponse : AopResponse
    {
        /// <summary>
        /// 总商家优惠金额
        /// </summary>
        [XmlElement("mercht_disc_amt")]
        public string MerchtDiscAmt { get; set; }

        /// <summary>
        /// 总订单金额
        /// </summary>
        [XmlElement("order_amt")]
        public string OrderAmt { get; set; }

        /// <summary>
        /// 总交易收款金额
        /// </summary>
        [XmlElement("recv_amt")]
        public string RecvAmt { get; set; }

        /// <summary>
        /// 总交易收款笔数
        /// </summary>
        [XmlElement("recv_cnt")]
        public long RecvCnt { get; set; }

        /// <summary>
        /// 总交易退款金额
        /// </summary>
        [XmlElement("refund_amt")]
        public string RefundAmt { get; set; }

        /// <summary>
        /// 总交易退款笔数
        /// </summary>
        [XmlElement("refund_cnt")]
        public long RefundCnt { get; set; }
    }
}
