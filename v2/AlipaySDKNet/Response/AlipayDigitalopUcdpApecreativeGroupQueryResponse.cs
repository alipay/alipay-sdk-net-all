using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalopUcdpApecreativeGroupQueryResponse.
    /// </summary>
    public class AlipayDigitalopUcdpApecreativeGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// ape创意组list
        /// </summary>
        [XmlElement("creative_group_list")]
        public CreativeGroup CreativeGroupList { get; set; }
    }
}
