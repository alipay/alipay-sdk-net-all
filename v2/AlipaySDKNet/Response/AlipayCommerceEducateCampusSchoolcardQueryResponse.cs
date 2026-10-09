using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusSchoolcardQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusSchoolcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户校园卡信息
        /// </summary>
        [XmlArray("school_card_list")]
        [XmlArrayItem("school_card")]
        public List<SchoolCard> SchoolCardList { get; set; }
    }
}
