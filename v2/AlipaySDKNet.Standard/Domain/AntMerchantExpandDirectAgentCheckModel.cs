using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandDirectAgentCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDirectAgentCheckModel : AopObject
    {
        /// <summary>
        /// 商机线索ID，从支付宝Leads下发接口中获取
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商户支付宝账号，一般为手机号或邮箱
        /// </summary>
        [XmlElement("merchant_account")]
        public string MerchantAccount { get; set; }
    }
}
