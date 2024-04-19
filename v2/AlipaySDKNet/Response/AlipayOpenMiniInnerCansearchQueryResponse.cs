using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerCansearchQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerCansearchQueryResponse : AopResponse
    {
        /// <summary>
        /// 该小程序是否可搜索
        /// </summary>
        [XmlElement("can_search")]
        public bool CanSearch { get; set; }
    }
}
