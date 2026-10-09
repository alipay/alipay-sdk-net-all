using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderLocalsellBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderLocalsellBatchqueryModel : AopObject
    {
        /// <summary>
        /// 订单创建结束日期，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_end_time")]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// 订单创建开始日期，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_start_time")]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态，传入此参数可查询指定状态的订单
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 分页页码，从1开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，单位：条目数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
