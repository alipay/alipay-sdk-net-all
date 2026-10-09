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
        /// 实际金额（总支付金额），单位为【元】
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
        /// 128
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 校园卡类型
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 该笔订单真实的创建时间，需精确到毫秒。
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
        /// 订单修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 用户open_id
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
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务号，由商家自定义，128个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
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
        /// 系统商编号。该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [XmlElement("rake_back_pid")]
        public string RakeBackPid { get; set; }

        /// <summary>
        /// 学校内标，录入学校接口返回的参数
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校收款账号
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
        /// 买家支付宝用户ID。 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
