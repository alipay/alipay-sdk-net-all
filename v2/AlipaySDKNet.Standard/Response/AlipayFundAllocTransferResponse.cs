using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAllocTransferResponse.
    /// </summary>
    public class AlipayFundAllocTransferResponse : AopResponse
    {
        /// <summary>
        /// 分佣时间
        /// </summary>
        [XmlElement("alloc_time")]
        public string AllocTime { get; set; }

        /// <summary>
        /// 分佣金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝分佣单据ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
