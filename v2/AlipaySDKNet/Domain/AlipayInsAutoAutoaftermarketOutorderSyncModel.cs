using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoaftermarketOutorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoaftermarketOutorderSyncModel : AopObject
    {
        /// <summary>
        /// 订单动作，譬如支付、退款、核销 PAY-支付 REFUND-退款 USE-核销使用
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 用户实际支付金额 单位：分 譬如：10000分
        /// </summary>
        [XmlElement("actual_pay_amount")]
        public long ActualPayAmount { get; set; }

        /// <summary>
        /// 支付宝用户2088账号
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 业务发生时间，不是接口传输时间，譬如支付时间，则就是用户支付的业务动作时间 格式：yyyyMMddHHmmss
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 车辆服务品类 保养-maintenance 轮胎-tyre 洗美-washBeauty 汽车用品-carSupplies
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 服务商的订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝唤起收银台的交易单号，不是服务商自己的业务订单号
        /// </summary>
        [XmlElement("pay_trade_no")]
        public string PayTradeNo { get; set; }

        /// <summary>
        /// 服务商品的标题名称
        /// </summary>
        [XmlElement("prod_title")]
        public string ProdTitle { get; set; }
    }
}
