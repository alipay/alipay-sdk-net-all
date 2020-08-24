using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppPdeductCzsignUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppPdeductCzsignUpgradeModel : AopObject
    {
        /// <summary>
        /// 行业代扣协议ID
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 机构PID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
