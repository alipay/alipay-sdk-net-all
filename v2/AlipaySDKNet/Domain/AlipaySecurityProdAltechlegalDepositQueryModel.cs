using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAltechlegalDepositQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAltechlegalDepositQueryModel : AopObject
    {
        /// <summary>
        /// 存证接口返回到存证编号
        /// </summary>
        [XmlElement("deposit_no")]
        public string DepositNo { get; set; }
    }
}
