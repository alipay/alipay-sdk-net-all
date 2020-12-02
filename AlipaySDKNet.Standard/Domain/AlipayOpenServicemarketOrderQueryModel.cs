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
        /// 订购服务订单ID，通过支付宝发送的 https://opendocs.alipay.com/apis/api_3/alipay.open.servicemarket.order.notify(服务市场商户确认订购通知) 通知获取。
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
