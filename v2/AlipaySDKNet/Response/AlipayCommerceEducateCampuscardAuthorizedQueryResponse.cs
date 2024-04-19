using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampuscardAuthorizedQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampuscardAuthorizedQueryResponse : AopResponse
    {
        /// <summary>
        /// 学生的校园卡列表
        /// </summary>
        [XmlArray("alipay_card_simple_list")]
        [XmlArrayItem("school_card_simple_info")]
        public List<SchoolCardSimpleInfo> AlipayCardSimpleList { get; set; }
    }
}
