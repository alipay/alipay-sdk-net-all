using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasOrderSyncModel : AopObject
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 优惠金额 单位 元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [XmlArray("discount_list")]
        [XmlArrayItem("gas_discount_info")]
        public List<GasDiscountInfo> DiscountList { get; set; }

        /// <summary>
        /// 扩展信息，用于业务扩展
        /// </summary>
        [XmlElement("ext_info")]
        public ExtensionMap ExtInfo { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("goods_info")]
        [XmlArrayItem("goods_info_detail")]
        public List<GoodsInfoDetail> GoodsInfo { get; set; }

        /// <summary>
        /// 机构编码，具体机构编码与支付宝小二约定
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 机构应用的支付宝pid
        /// </summary>
        [XmlElement("inst_pid")]
        public string InstPid { get; set; }

        /// <summary>
        /// 订单最后修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 加油：oil，充值：recharge
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 机构侧交易流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单实际支付金额 单位 元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [XmlElement("payment_time")]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 具体值与支付宝小二约定
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 订单总金额 单位 元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易方式
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
