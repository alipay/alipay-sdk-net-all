using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandTradeorderQueryResponse.
    /// </summary>
    public class AntMerchantExpandTradeorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单金额；单位：分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 业务序列号
        /// </summary>
        [XmlElement("biz_seq")]
        public string BizSeq { get; set; }

        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订单扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("gmt_paid")]
        public string GmtPaid { get; set; }

        /// <summary>
        /// 商品订单列表
        /// </summary>
        [XmlArray("item_orders")]
        [XmlArrayItem("item_order_open_data")]
        public List<ItemOrderOpenData> ItemOrders { get; set; }

        /// <summary>
        /// 订单物流状态
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商家补贴金额；单位：分
        /// </summary>
        [XmlElement("merchant_subsidy_amount")]
        public long MerchantSubsidyAmount { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务类型；TO_SHOP(到店)、GAS(加油)
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 平台商ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 平台补贴金额；单位：分
        /// </summary>
        [XmlElement("partner_subsidy_amount")]
        public long PartnerSubsidyAmount { get; set; }

        /// <summary>
        /// 订单实际支付金额；单位：分
        /// </summary>
        [XmlElement("real_amount")]
        public long RealAmount { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单状态；INIT(初始化)、WAIT_PAY(待支付)、PAID(已支付)、TIMEOUT_CLOSED(超时关闭)、SUCCESS_FINISHED(订单成功完结)、REFUNDED(已退款)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 业务类型；GAS_SERVICE(加油业务)，SHOP_SERVICE(到店业务)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
