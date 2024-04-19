using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsDataAuthorizationQueryResponse.
    /// </summary>
    public class AlipayInsDataAuthorizationQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权文件URL
        /// </summary>
        [XmlElement("auth_agreement_url")]
        public string AuthAgreementUrl { get; set; }

        /// <summary>
        /// 与被保人关系，枚举定义：1-本人，2-配偶，3-子女，4-父母，5-法定监护人，99-其他
        /// </summary>
        [XmlElement("relation_to_insured")]
        public string RelationToInsured { get; set; }
    }
}
