using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentBuyoutInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentBuyoutInfoDTO : AopObject
    {
        /// <summary>
        /// 租赁阶梯购买分期号
        /// </summary>
        [XmlElement("buyout_installment_no")]
        public long BuyoutInstallmentNo { get; set; }

        /// <summary>
        /// 原租赁交易组件订单号
        /// </summary>
        [XmlElement("origin_order_id")]
        public string OriginOrderId { get; set; }

        /// <summary>
        /// 支付宝服务器主动通知商户服务器里指定的页面http/https路径
        /// </summary>
        [XmlElement("pay_notify_url")]
        public string PayNotifyUrl { get; set; }
    }
}
