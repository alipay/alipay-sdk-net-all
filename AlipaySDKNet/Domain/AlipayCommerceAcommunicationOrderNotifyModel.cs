using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationOrderNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationOrderNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝侧订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 充值结果描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// SUCCESS 业务办理成功 FAILED 业务办理失败 在回调接口中只有终态
        /// </summary>
        [XmlElement("out_order_status")]
        public string OutOrderStatus { get; set; }
    }
}
