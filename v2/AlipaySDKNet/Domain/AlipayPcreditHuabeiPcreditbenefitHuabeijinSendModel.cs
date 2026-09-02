using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitHuabeijinSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitHuabeijinSendModel : AopObject
    {
        /// <summary>
        /// 发奖活动id,花呗分配
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 123 表示123分，单位为分，1.23元
        /// </summary>
        [XmlElement("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 行业场景标识,依赖双方约定
        /// </summary>
        [XmlElement("industry_value")]
        public string IndustryValue { get; set; }

        /// <summary>
        /// 用于给场景获得花呗金时设置权益展示文案使用
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 出行订单描述，商品信息等
        /// </summary>
        [XmlElement("order_desc")]
        public string OrderDesc { get; set; }

        /// <summary>
        /// 标准日期格式，如2020-01-01 00:00:01 比如用户支付的时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 商家业务订单号（商家侧订单号，风险巡检时用于与支付宝交易系统对账）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝订单
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
