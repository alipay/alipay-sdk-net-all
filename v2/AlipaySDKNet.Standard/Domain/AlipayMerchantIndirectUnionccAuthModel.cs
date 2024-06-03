using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectUnionccAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectUnionccAuthModel : AopObject
    {
        /// <summary>
        /// 收单机构在支付宝签约的商户名称，和PID对应。
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 收单机构的PID
        /// </summary>
        [XmlElement("org_pid")]
        public string OrgPid { get; set; }
    }
}
