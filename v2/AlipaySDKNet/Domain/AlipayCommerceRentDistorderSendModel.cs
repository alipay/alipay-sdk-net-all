using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentDistorderSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentDistorderSendModel : AopObject
    {
        /// <summary>
        /// 分销订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 渠道买家ID
        /// </summary>
        [XmlElement("channel_buyer_id")]
        public string ChannelBuyerId { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [XmlElement("channel_order_id")]
        public string ChannelOrderId { get; set; }

        /// <summary>
        /// 快递公司编码
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 分销渠道
        /// </summary>
        [XmlElement("distribution_channel")]
        public string DistributionChannel { get; set; }

        /// <summary>
        /// 发货人地址
        /// </summary>
        [XmlElement("sender_address")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 行政区划编码 最小行政单位code，若是地区级别，则为地区级别的id；否则为城市级别的id(long型，6位)
        /// </summary>
        [XmlElement("sender_district_code")]
        public string SenderDistrictCode { get; set; }

        /// <summary>
        /// 张三
        /// </summary>
        [XmlElement("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 发货人手机号
        /// </summary>
        [XmlElement("sender_phone")]
        public string SenderPhone { get; set; }

        /// <summary>
        /// 快递dan'hao
        /// </summary>
        [XmlElement("waybill_id")]
        public string WaybillId { get; set; }
    }
}
