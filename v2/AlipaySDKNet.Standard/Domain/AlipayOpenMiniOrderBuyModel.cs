using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderBuyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderBuyModel : AopObject
    {
        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝登录账号。 buyer_logon_id和buyer_id两者传其一，和buyer_id不能同时为空，建议通过buyer_id来传递买家信息。
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 购物车订单列表
        /// </summary>
        [XmlArray("mini_order_create_requests")]
        [XmlArrayItem("order_buy_d_t_o")]
        public List<OrderBuyDTO> MiniOrderCreateRequests { get; set; }

        /// <summary>
        /// 交易购买号，唯一标识当前用户的此次购买行为
        /// </summary>
        [XmlElement("order_buy_no")]
        public string OrderBuyNo { get; set; }

        /// <summary>
        /// 订单优惠信息
        /// </summary>
        [XmlElement("promo_detail_info")]
        public PromoDetailInfoDTO PromoDetailInfo { get; set; }

        /// <summary>
        /// 追踪ID，公域分发场景必传，会影响主播归因、分享员归因等；通过调用 my.checkBeforeAddOrder 接口返回
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 订单相对超时时间。从交易创建时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 默认值为3h。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
