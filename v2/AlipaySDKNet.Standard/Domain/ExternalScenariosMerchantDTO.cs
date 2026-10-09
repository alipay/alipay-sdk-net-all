using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalScenariosMerchantDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalScenariosMerchantDTO : AopObject
    {
        /// <summary>
        /// 商户的支付宝登录号
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户的支付宝PID
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商户统一社会信用代码
        /// </summary>
        [XmlElement("merchant_uscc")]
        public string MerchantUscc { get; set; }

        /// <summary>
        /// 在支付宝完成进件的二级商户ID，需和商户主体身份一致
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
