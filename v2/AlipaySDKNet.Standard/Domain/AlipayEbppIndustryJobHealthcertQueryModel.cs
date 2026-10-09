using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryJobHealthcertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryJobHealthcertQueryModel : AopObject
    {
        /// <summary>
        /// 一次认证的唯一标识,在商户调用认证页申请是拼接在回调地址上
        /// </summary>
        [XmlElement("certify_token")]
        public string CertifyToken { get; set; }
    }
}
