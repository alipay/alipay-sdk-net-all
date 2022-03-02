using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountTradeQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 资金单明细
        /// </summary>
        [XmlArray("trade_fund_bill_list")]
        [XmlArrayItem("trade_fund_bill_detail")]
        public List<TradeFundBillDetail> TradeFundBillList { get; set; }

        /// <summary>
        /// 交易信息集合。查询为批量查询时，使用该结果返回
        /// </summary>
        [XmlArray("trade_info_list")]
        [XmlArrayItem("trade_info_d_t_o")]
        public List<TradeInfoDTO> TradeInfoList { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
