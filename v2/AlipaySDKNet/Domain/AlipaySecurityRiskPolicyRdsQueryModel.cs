using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyRdsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskPolicyRdsQueryModel : AopObject
    {
        /// <summary>
        /// 具体需传递的参数请参考接入文档中的参数列表 https://yuque.antfin-inc.com/tecsec/rds/insertdoc
        /// </summary>
        [XmlElement("rds_params")]
        public string RdsParams { get; set; }
    }
}
