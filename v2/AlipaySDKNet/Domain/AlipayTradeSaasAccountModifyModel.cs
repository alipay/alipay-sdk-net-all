using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasAccountModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasAccountModifyModel : AopObject
    {
        /// <summary>
        /// 需要变更企业主体信息的SaaS客户ID。该客户必须属于当前调用商户，且当前仅允许存在一个可用银行转账账户。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 变更后的企业登记号。企业主体发生变化且未命中企业真实性校验豁免配置时必填；企业名称未变化且本字段不传时保留原企业登记号。
        /// </summary>
        [XmlElement("enterprise_registration_no")]
        public string EnterpriseRegistrationNo { get; set; }

        /// <summary>
        /// 变更后的企业名称。与当前企业名称和企业登记号均一致时按幂等成功返回。
        /// </summary>
        [XmlElement("out_merchant_name")]
        public string OutMerchantName { get; set; }
    }
}
