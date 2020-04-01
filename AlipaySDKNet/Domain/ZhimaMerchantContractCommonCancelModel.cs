using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantContractCommonCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantContractCommonCancelModel : AopObject
    {
        /// <summary>
        /// 合约单号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 应约者id(淘宝id/支付宝user_id)
        /// </summary>
        [XmlElement("sign_principal_id")]
        public string SignPrincipalId { get; set; }
    }
}
