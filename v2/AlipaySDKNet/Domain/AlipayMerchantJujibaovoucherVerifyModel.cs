using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantJujibaovoucherVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantJujibaovoucherVerifyModel : AopObject
    {
        /// <summary>
        /// 移动核销入参根节点
        /// </summary>
        [XmlElement("contract_root")]
        public ChinaMobileContractRoot ContractRoot { get; set; }
    }
}
