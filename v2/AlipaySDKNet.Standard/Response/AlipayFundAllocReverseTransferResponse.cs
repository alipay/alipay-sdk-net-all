using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAllocReverseTransferResponse.
    /// </summary>
    public class AlipayFundAllocReverseTransferResponse : AopResponse
    {
        /// <summary>
        /// 退款金额（元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 退分佣单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("reverse_time")]
        public string ReverseTime { get; set; }

        /// <summary>
        /// FINISHED-退款成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
