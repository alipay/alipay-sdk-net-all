using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseUserpreorderQueryResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseUserpreorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 预订单信息
        /// </summary>
        [XmlElement("advance_order")]
        public AdvanceOrder AdvanceOrder { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 商圈是否开通会员系统
        /// </summary>
        [XmlElement("mall_has_card")]
        public bool MallHasCard { get; set; }

        /// <summary>
        /// 用户是否开通会员卡
        /// </summary>
        [XmlElement("open_card")]
        public bool OpenCard { get; set; }

        /// <summary>
        /// 开通会员卡地址
        /// </summary>
        [XmlElement("open_card_url")]
        public string OpenCardUrl { get; set; }

        /// <summary>
        /// 口碑交易订单ID。只有在用户真实下单才会有。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态，包含：（初始化：INIT，待付款：WAIT_PAY,  付款成功：PAID，关闭状态：CLOSE）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
