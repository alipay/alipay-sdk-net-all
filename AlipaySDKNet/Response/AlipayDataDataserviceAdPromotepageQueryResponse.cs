using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageQueryResponse : AopResponse
    {
        /// <summary>
        /// 留资页信息列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("promote_page")]
        public List<PromotePage> List { get; set; }
    }
}
