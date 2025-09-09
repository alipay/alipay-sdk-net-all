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

        /// <summary>
        /// true表示当前购买订单创建不需要自动创建支付宝trade_no。商户需自行处理收款后，通过alipay.commerce.rent.order.pay.sync接口进行同步。
        /// </summary>
        [XmlElement("sync_pay")]
        public bool SyncPay { get; set; }
    }
}
