using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcApplyorderConsultModel : AopObject
    {
        /// <summary>
        /// 申请ETC时的协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 注销咨询
        /// </summary>
        [XmlElement("consult_scene")]
        public string ConsultScene { get; set; }
    }
}
