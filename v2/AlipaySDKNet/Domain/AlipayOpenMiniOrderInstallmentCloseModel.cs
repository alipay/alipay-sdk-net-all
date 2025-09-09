using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderInstallmentCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderInstallmentCloseModel : AopObject
    {
        /// <summary>
        /// 分期单号。在代扣等场景下使用
        /// </summary>
        [XmlElement("installment_order_id")]
        public string InstallmentOrderId { get; set; }

        /// <summary>
        /// 用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 分期单外部请求号，由商家自定义。通过外部分期单号关闭分期单，需传入业务主单号
        /// </summary>
        [XmlElement("out_installment_order_id")]
        public string OutInstallmentOrderId { get; set; }

        /// <summary>
        /// 商家自定义订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
