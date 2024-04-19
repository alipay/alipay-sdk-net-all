using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeStyleQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApecreativeStyleQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询出的风格id和风格mock
        /// </summary>
        [XmlArray("creative_styles")]
        [XmlArrayItem("creative_style")]
        public List<CreativeStyle> CreativeStyles { get; set; }
    }
}
