using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeStyledesignrelationQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApecreativeStyledesignrelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 布局id 和对应的关联信息
        /// </summary>
        [XmlElement("creative_design_info_list")]
        public CreativeDesignInfo CreativeDesignInfoList { get; set; }
    }
}
