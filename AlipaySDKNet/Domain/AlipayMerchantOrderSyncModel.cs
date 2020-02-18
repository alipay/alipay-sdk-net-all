using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单金额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 买家userId
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// buyer_info与buyer_user_id必选其一
        /// </summary>
        [XmlElement("buyer_info")]
        public UserInfomation BuyerInfo { get; set; }

        /// <summary>
        /// 扩展信息，请参见产品文档
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order_info")]
        public List<ItemOrderInfo> ItemOrderList { get; set; }

        /// <summary>
        /// 物流信息  列表最多支持物流信息个数，请参考产品文档  注：若该值不为空，且物流信息同步至我的快递，则在查询订单时可返回具体物流信息
        /// </summary>
        [XmlArray("logistics_info_list")]
        [XmlArrayItem("order_logistics_information_request")]
        public List<OrderLogisticsInformationRequest> LogisticsInfoList { get; set; }

        /// <summary>
        /// 外部订单号 out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签约商户userId
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付金额 需要实际支付的金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付超时时间，超过时间支付宝自行关闭订单
        /// </summary>
        [XmlElement("pay_timeout_express")]
        public string PayTimeoutExpress { get; set; }

        /// <summary>
        /// 商户订单同步记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 卖家userId
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
