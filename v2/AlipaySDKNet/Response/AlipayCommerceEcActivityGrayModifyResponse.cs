using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcActivityGrayModifyResponse.
    /// </summary>
    public class AlipayCommerceEcActivityGrayModifyResponse : AopResponse
    {
        /// <summary>
        /// 用户扫码加入指定的营销活动测试企业，用于活动灰度测试。
        /// </summary>
        [XmlElement("benefit_enterprise_invite_code")]
        public string BenefitEnterpriseInviteCode { get; set; }
    }
}
