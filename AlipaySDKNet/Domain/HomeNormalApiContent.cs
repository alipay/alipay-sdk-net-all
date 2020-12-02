using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HomeNormalApiContent Data Structure.
    /// </summary>
    [Serializable]
    public class HomeNormalApiContent : AopObject
    {
        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 订单跳转链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 如果线下排队，用户是否扫描小票上的二维码
        /// </summary>
        [XmlElement("is_scan")]
        public string IsScan { get; set; }

        /// <summary>
        /// 商户详细地址
        /// </summary>
        [XmlElement("merchant_address")]
        public string MerchantAddress { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 在线点餐地址
        /// </summary>
        [XmlElement("order_url")]
        public string OrderUrl { get; set; }

        /// <summary>
        /// 叫号业务填排队码
        /// </summary>
        [XmlElement("queue_code")]
        public string QueueCode { get; set; }

        /// <summary>
        /// 排队剩余人数
        /// </summary>
        [XmlElement("queue_num")]
        public string QueueNum { get; set; }

        /// <summary>
        /// 排队途径(线上还是线下排队)
        /// </summary>
        [XmlElement("queue_way")]
        public string QueueWay { get; set; }

        /// <summary>
        /// 门店的shop_id(唯一)
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
