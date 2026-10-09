using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSmddOrderDetailQueryResponse.
    /// </summary>
    public class AlipayOfflineSmddOrderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 取餐号
        /// </summary>
        [XmlElement("claim_code")]
        public string ClaimCode { get; set; }

        /// <summary>
        /// 创建日期，1970至今毫秒值
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 商品订单列表
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order_bean")]
        public List<ItemOrderBean> ItemOrderList { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态,详见OrderStatusEnum，枚举数量大于10
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单状态说明，详见OrderStatusEnum，枚举数量大于10
        /// </summary>
        [XmlElement("order_status_desc")]
        public string OrderStatusDesc { get; set; }

        /// <summary>
        /// 订单超时时间，指定到具体时间，不度量
        /// </summary>
        [XmlElement("order_timeout")]
        public string OrderTimeout { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 订单实际支付价格 单位：元
        /// </summary>
        [XmlElement("real_price")]
        public string RealPrice { get; set; }

        /// <summary>
        /// 必填信息
        /// </summary>
        [XmlArray("require_info_list")]
        [XmlArrayItem("require_bean")]
        public List<RequireBean> RequireInfoList { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("table_no")]
        public string TableNo { get; set; }

        /// <summary>
        /// 超时时间 1970至今毫秒值
        /// </summary>
        [XmlElement("timeout_stamp")]
        public long TimeoutStamp { get; set; }

        /// <summary>
        /// 订单总价格 单位：元
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
