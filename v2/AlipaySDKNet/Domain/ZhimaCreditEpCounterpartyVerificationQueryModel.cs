using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCounterpartyVerificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCounterpartyVerificationQueryModel : AopObject
    {
        /// <summary>
        /// 授权编号
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 社会统一信用代码、注册号、企业名可任选一个入参，建议优先使用统代
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
