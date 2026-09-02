using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasAccountCreateResponse.
    /// </summary>
    public class AlipayTradeSaasAccountCreateResponse : AopResponse
    {
        /// <summary>
        /// SaaS客户ID。后续账户查询和交易请求可使用该字段标识客户。
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 企业登记号，用于标识企业主体并与企业名称进行一致性校验。境内企业通常填写统一社会信用代码。
        /// </summary>
        [XmlElement("enterprise_registration_no")]
        public string EnterpriseRegistrationNo { get; set; }

        /// <summary>
        /// 机构账户名称。
        /// </summary>
        [XmlElement("inst_account_name")]
        public string InstAccountName { get; set; }

        /// <summary>
        /// 机构账户号。
        /// </summary>
        [XmlElement("inst_account_no")]
        public string InstAccountNo { get; set; }

        /// <summary>
        /// 开户机构名称。
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
