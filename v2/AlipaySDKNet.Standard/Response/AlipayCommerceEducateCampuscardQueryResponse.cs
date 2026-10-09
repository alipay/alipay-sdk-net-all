using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampuscardQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampuscardQueryResponse : AopResponse
    {
        /// <summary>
        /// 学生的校园卡列表
        /// </summary>
        [XmlArray("alipay_card_list")]
        [XmlArrayItem("school_card_info")]
        public List<SchoolCardInfo> AlipayCardList { get; set; }
    }
}
