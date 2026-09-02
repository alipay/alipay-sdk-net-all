using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentDistorderModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentDistorderModifyModel : AopObject
    {
        /// <summary>
        /// 分销订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 买家地址修改申请
        /// </summary>
        [XmlElement("buyer_address_modify_apply_info")]
        public DistributionProcessBuyerAddressModifyApplyDTO BuyerAddressModifyApplyInfo { get; set; }

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
        /// 分销渠道
        /// </summary>
        [XmlElement("distribution_channel")]
        public string DistributionChannel { get; set; }

        /// <summary>
        /// 修改信息类型
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 价格和租期修改信息
        /// </summary>
        [XmlElement("price_and_period_info")]
        public DistributionOrderPriceAndPeriodDTO PriceAndPeriodInfo { get; set; }

        /// <summary>
        /// 订单归还地址
        /// </summary>
        [XmlElement("return_address_info")]
        public DistributionOrderReturnAddressDTO ReturnAddressInfo { get; set; }
    }
}
