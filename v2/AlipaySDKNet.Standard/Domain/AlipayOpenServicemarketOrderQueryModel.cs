using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketOrderQueryModel : AopObject
    {
        /// <summary>
        /// 订购服务订单ID，通过支付宝发送的 <a href="https://opendocs.alipay.com/isv/b7f7864a_alipay.open.servicemarket.order.notify?scene=common&pathHash=af6ed436">服务市场商户确认订购通知</a> 获取。
        /// </summary>
        [XmlElement("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 查询开始页码，1 为第一页。
        /// </summary>
        [XmlElement("start_page")]
        public string StartPage { get; set; }
    }
}
