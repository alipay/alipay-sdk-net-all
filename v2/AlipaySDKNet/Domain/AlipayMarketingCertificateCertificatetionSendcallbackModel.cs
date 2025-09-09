using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCertificateCertificatetionSendcallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCertificateCertificatetionSendcallbackModel : AopObject
    {
        /// <summary>
        /// 用户OpenID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 购买商品的订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家发放凭证的结果，支付宝会依此字段决策是否处理结果。
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 商家发放券码结果列表
        /// </summary>
        [XmlArray("send_code_result_list")]
        [XmlArrayItem("send_code_result")]
        public List<SendCodeResult> SendCodeResultList { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
