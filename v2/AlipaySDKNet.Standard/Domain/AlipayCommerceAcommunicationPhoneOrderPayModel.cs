using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationPhoneOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationPhoneOrderPayModel : AopObject
    {
        /// <summary>
        /// 话费面额
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 需要充值手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外部订单号用于幂等处理，两次重复请求必须保证一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 价格上限。由于代扣模式感知不到选品过程，商家可以选择商品价格上限避免超出价格的商品
        /// </summary>
        [XmlElement("price_ceiling")]
        public string PriceCeiling { get; set; }

        /// <summary>
        /// 号卡代充正常情况下一个号码关联一个订单
        /// </summary>
        [XmlElement("related_biz_no")]
        public string RelatedBizNo { get; set; }

        /// <summary>
        /// 支付宝侧分配场景码，用于风控限制和商品查询
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 记录号卡套餐发生日期，同样一个号码正常情况下值会保持一致
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 号卡套餐总期数
        /// </summary>
        [XmlElement("step_count")]
        public long StepCount { get; set; }

        /// <summary>
        /// 当前号卡套餐为第10期
        /// </summary>
        [XmlElement("step_number")]
        public long StepNumber { get; set; }

        /// <summary>
        /// 订单渠道来源。用于统计同个商家不同渠道的订单
        /// </summary>
        [XmlElement("sub_source")]
        public string SubSource { get; set; }
    }
}
