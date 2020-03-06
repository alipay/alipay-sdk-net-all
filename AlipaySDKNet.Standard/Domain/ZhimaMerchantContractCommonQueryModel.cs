using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantContractCommonQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantContractCommonQueryModel : AopObject
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

        /// <summary>
        /// 应约者类型:ZHIMA_ROLE:芝麻用户 ALIPAY_ROLE:支付宝用户 TAOBAO_ROLE:淘宝用户
        /// </summary>
        [XmlElement("sign_principal_type")]
        public string SignPrincipalType { get; set; }
    }
}
