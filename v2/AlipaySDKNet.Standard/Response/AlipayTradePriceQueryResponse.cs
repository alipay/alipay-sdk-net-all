using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradePriceQueryResponse.
    /// </summary>
    public class AlipayTradePriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 该价格实例是否可用
        /// </summary>
        [XmlElement("active")]
        public bool Active { get; set; }

        /// <summary>
        /// 自定义单价，当 unit_amount 为空时必选
        /// </summary>
        [XmlElement("custom_unit_amount")]
        public CustomUnitAmount CustomUnitAmount { get; set; }

        /// <summary>
        /// 满足了eligibility_type的身份购买后，失效的时间。如3d = 3天， 3m = 3月
        /// </summary>
        [XmlElement("eligibility_expire_time")]
        public string EligibilityExpireTime { get; set; }

        /// <summary>
        /// 只有满足该类型的身份才可以购买。具体的枚举值待支付宝侧分配
        /// </summary>
        [XmlElement("eligibility_type")]
        public string EligibilityType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 价格id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商户需要保存在价格模型中的元数据
        /// </summary>
        [XmlElement("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// 关联的商品信息
        /// </summary>
        [XmlElement("product")]
        public NexusPayProduct Product { get; set; }

        /// <summary>
        /// 关联商品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 循环计价配置，用于订阅等场景
        /// </summary>
        [XmlElement("recurring")]
        public RecurringConfig Recurring { get; set; }

        /// <summary>
        /// 价格类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 单位金额，单位：分，当 custom_unit_amount 为空时必选
        /// </summary>
        [XmlElement("unit_amount")]
        public long UnitAmount { get; set; }
    }
}
