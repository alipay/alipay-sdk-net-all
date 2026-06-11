using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryCardlistQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryCardlistQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("card_list")]
        [XmlArrayItem("biz_card")]
        public List<BizCard> CardList { get; set; }

        /// <summary>
        /// 数据总量,单位：条
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
