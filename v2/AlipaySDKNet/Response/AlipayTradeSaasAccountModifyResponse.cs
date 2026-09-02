using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasAccountModifyResponse.
    /// </summary>
    public class AlipayTradeSaasAccountModifyResponse : AopResponse
    {
        /// <summary>
        /// 完成企业主体信息变更的SaaS客户ID。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 当前生效的企业登记号。账户未保存企业登记号时不返回。
        /// </summary>
        [XmlElement("enterprise_registration_no")]
        public string EnterpriseRegistrationNo { get; set; }

        /// <summary>
        /// 当前生效的企业名称。
        /// </summary>
        [XmlElement("out_merchant_name")]
        public string OutMerchantName { get; set; }
    }
}
