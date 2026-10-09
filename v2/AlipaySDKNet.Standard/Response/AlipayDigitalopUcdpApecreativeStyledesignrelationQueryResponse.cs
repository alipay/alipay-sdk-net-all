using System;
using System.Xml.Serialization;
using System.Collections.Generic;
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

        /// <summary>
        /// 布局id对应的关联信息
        /// </summary>
        [XmlArray("select_design_info_list")]
        [XmlArrayItem("creative_design_info")]
        public List<CreativeDesignInfo> SelectDesignInfoList { get; set; }
    }
}
