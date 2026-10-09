using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionPhonecardagreementQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionPhonecardagreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 号卡协议列表
        /// </summary>
        [XmlArray("agreement_list")]
        [XmlArrayItem("phone_card_agreement_model")]
        public List<PhoneCardAgreementModel> AgreementList { get; set; }

        /// <summary>
        /// 协议id
        /// </summary>
        [XmlElement("agreement_request_id")]
        public string AgreementRequestId { get; set; }
    }
}
