using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentCodeGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalPaymentCodeGetResponse : AopResponse
    {
        /// <summary>
        /// 脱敏支付宝登录名
        /// </summary>
        [XmlElement("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 用户付款码码值
        /// </summary>
        [XmlElement("payment_code")]
        public string PaymentCode { get; set; }
    }
}
