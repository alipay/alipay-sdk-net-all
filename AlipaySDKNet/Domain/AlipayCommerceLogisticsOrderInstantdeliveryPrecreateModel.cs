using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel : AopObject
    {
        /// <summary>
        /// 消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝用户uid；如果consumer_source是wx，则consumer_id可以为空
        /// </summary>
        [XmlElement("consumer_id")]
        public string ConsumerId { get; set; }

        /// <summary>
        /// 消费者通知明细
        /// </summary>
        [XmlElement("consumer_notify")]
        public ConsumerNotifyIstd ConsumerNotify { get; set; }

        /// <summary>
        /// 消费者来源, 支付宝：alipay, 微信：wx
        /// </summary>
        [XmlElement("consumer_source")]
        public string ConsumerSource { get; set; }

        /// <summary>
        /// 商品明细
        /// </summary>
        [XmlArray("goods_details")]
        [XmlArrayItem("goods_detail_istd")]
        public List<GoodsDetailIstd> GoodsDetails { get; set; }

        /// <summary>
        /// 商品汇总信息
        /// </summary>
        [XmlElement("goods_info")]
        public GoodsInfoIstd GoodsInfo { get; set; }

        /// <summary>
        /// 即时配送公司配置列表
        /// </summary>
        [XmlArray("logistics_companies")]
        [XmlArrayItem("logistics_company_istd")]
        public List<LogisticsCompanyIstd> LogisticsCompanies { get; set; }

        /// <summary>
        /// 即时配送订单扩展
        /// </summary>
        [XmlElement("order_ext_istd")]
        public OrderExtIstd OrderExtIstd { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [XmlElement("receiver")]
        public ReceiverIstd Receiver { get; set; }

        /// <summary>
        /// 发件人
        /// </summary>
        [XmlElement("sender")]
        public SenderIstd Sender { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }
    }
}
