using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhiteBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsWhiteBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("sports_white_item")]
        public List<SportsWhiteItem> List { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
