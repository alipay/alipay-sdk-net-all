using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrReferralCodeRequestParamDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrReferralCodeRequestParamDTO : AopObject
    {
        /// <summary>
        /// 如果本次推荐需要定向推荐至某个商户，则此处填入商户id
        /// </summary>
        [XmlElement("beneficiary_id")]
        public string BeneficiaryId { get; set; }

        /// <summary>
        /// 本次推荐关联订单需要被发送凭证pdf的公用邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// HOME_PAGE:跳转至主页 BENEFICIARY_PAGE：跳转至账号选择页
        /// </summary>
        [XmlElement("link_target")]
        public string LinkTarget { get; set; }
    }
}
