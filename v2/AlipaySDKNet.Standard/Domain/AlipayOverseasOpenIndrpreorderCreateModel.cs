using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasOpenIndrpreorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasOpenIndrpreorderCreateModel : AopObject
    {
        /// <summary>
        /// 付款人支付宝登录id号
        /// </summary>
        [XmlElement("alipay_login_id")]
        public string AlipayLoginId { get; set; }

        /// <summary>
        /// 买家（学生）信息
        /// </summary>
        [XmlElement("buyer_info")]
        public IndrISVUserDTO BuyerInfo { get; set; }

        /// <summary>
        /// 付款人信息
        /// </summary>
        [XmlElement("payer_info")]
        public IndrISVUserDTO PayerInfo { get; set; }

        /// <summary>
        /// 缴费信息
        /// </summary>
        [XmlElement("payment_info")]
        public IndrISVPaymentInfoDTO PaymentInfo { get; set; }

        /// <summary>
        /// 订单号为空表示新建，传值表示更新
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 请求id, 做幂等控制
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景定制化信息
        /// </summary>
        [XmlElement("scene_custom_param")]
        public string SceneCustomParam { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
