using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryRentAccfundQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryRentAccfundQueryResponse : AopResponse
    {
        /// <summary>
        /// 公积金付总金额，单位(分)
        /// </summary>
        [XmlElement("acc_amount")]
        public string AccAmount { get; set; }

        /// <summary>
        /// 行业订单编码
        /// </summary>
        [XmlElement("biz_seq")]
        public string BizSeq { get; set; }

        /// <summary>
        /// 订单状态说明
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 租房平台的外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 自费总金额，单位(分)
        /// </summary>
        [XmlElement("self_amount")]
        public string SelfAmount { get; set; }

        /// <summary>
        /// 租房平台房源租赁账单标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位(分)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
