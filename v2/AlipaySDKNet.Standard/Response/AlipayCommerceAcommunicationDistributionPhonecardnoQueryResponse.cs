using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionPhonecardnoQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDistributionPhonecardnoQueryResponse : AopResponse
    {
        /// <summary>
        /// 号卡手机号列表
        /// </summary>
        [XmlArray("phone_card_number_list")]
        [XmlArrayItem("phone_card_number_model")]
        public List<PhoneCardNumberModel> PhoneCardNumberList { get; set; }
    }
}
