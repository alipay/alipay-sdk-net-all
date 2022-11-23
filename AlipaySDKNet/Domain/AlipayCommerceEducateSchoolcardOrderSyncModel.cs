using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchoolcardOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchoolcardOrderSyncModel : AopObject
    {
        /// <summary>
        /// 实际金额（总支付金额）
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [XmlElement("applet_app_id")]
        public string AppletAppId { get; set; }

        /// <summary>
        /// 校园卡余额
        /// </summary>
        [XmlElement("card_balance")]
        public string CardBalance { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 该笔订单真实的创建时间，需精确到毫秒。时间格式为 yyyy-MM-dd HH:mm:ss.SSS。同一笔订单保持不变
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlElement("goods_orders")]
        public GoodsOrder GoodsOrders { get; set; }

        /// <summary>
        /// 商家名称，不传默认展示学校名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 订单修改时间，时间格式为 yyyy-MM-dd HH:mm:ss.SSS。用于订单状态或数据变化较快的顺序控制，防止乱序。order_modified_time较晚的同步会被最终存储，order_modified_time相同的两次同步会被幂等处理。
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单详情链接
        /// </summary>
        [XmlElement("order_detail_url")]
        public string OrderDetailUrl { get; set; }

        /// <summary>
        /// 订单状态 消费成功 CONSUME_S ；已退款：REFUNDED； 开卡成功 CARD_ACTIVED；消费失败：UN_CHARGE 充值成功 RECHARGE_S
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付地点
        /// </summary>
        [XmlElement("pay_address")]
        public string PayAddress { get; set; }

        /// <summary>
        /// 付款方式，不传默认展示学校名称+校园卡+（卡号后四位）
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }

        /// <summary>
        /// 返佣pid
        /// </summary>
        [XmlElement("rake_back_pid")]
        public string RakeBackPid { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校pid
        /// </summary>
        [XmlElement("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 服务提供者名称
        /// </summary>
        [XmlElement("service_provider_name")]
        public string ServiceProviderName { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
