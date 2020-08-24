using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementUserverifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementUserverifyQueryModel : AopObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 申请时获取的token
        /// </summary>
        [XmlElement("apply_token")]
        public string ApplyToken { get; set; }
    }
}
