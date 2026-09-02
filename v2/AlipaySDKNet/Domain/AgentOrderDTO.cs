using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgentOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AgentOrderDTO : AopObject
    {
        /// <summary>
        /// 买家实付金额，单位元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 订单总金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单营销优惠金额，单位元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 轮询单号，可用与支付宝Agent订单关联
        /// </summary>
        [XmlElement("out_shake_no")]
        public string OutShakeNo { get; set; }

        /// <summary>
        /// 用户支付成功时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 商家入驻支付宝名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }
    }
}
