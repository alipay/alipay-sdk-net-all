using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasOpenIndraccountConsultResponse.
    /// </summary>
    public class AlipayOverseasOpenIndraccountConsultResponse : AopResponse
    {
        /// <summary>
        /// 账户id, 结果为success才会返回, 失败返回空
        /// </summary>
        [XmlElement("beneficiary_account_id")]
        public string BeneficiaryAccountId { get; set; }

        /// <summary>
        /// 验证结果
        /// </summary>
        [XmlElement("result")]
        public IndrISVResult Result { get; set; }
    }
}
