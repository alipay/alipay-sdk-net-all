using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundIdentitypayMemberQueryResponse.
    /// </summary>
    public class AlipayFundIdentitypayMemberQueryResponse : AopResponse
    {
        /// <summary>
        /// 鉴权方式标签 （estate_audit-物业审核/self_scan-自主扫码/live_payment-生活缴费/government_org-政府审核）
        /// </summary>
        [XmlElement("authentication_type")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// 成员类型
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [XmlElement("member_name")]
        public string MemberName { get; set; }

        /// <summary>
        /// 标识用户是否签约
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
