using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillchargeOrderBatchcreateResponse.
    /// </summary>
    public class AlipayEbppBillchargeOrderBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 行业收单流水,50新链路单笔订单创建的时候返回。对应原本的子订单号中的参数
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 用于作为交易号拉起 my.tradePay 收银台
        /// </summary>
        [XmlElement("merge_trade_no")]
        public string MergeTradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 主订单流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 主订单状态 I-等待付款 P-已支付 C-单据关闭
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子订单列
        /// </summary>
        [XmlArray("sub_order_list")]
        [XmlArrayItem("sub_order_info")]
        public List<SubOrderInfo> SubOrderList { get; set; }

        /// <summary>
        /// 总支付金额
        /// </summary>
        [XmlElement("total_pay_amount")]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// 统一收单流水号用于非合并支付情况下50新链路拉起收银台
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
