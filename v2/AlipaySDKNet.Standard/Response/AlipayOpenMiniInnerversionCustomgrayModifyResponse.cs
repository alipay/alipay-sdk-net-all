using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionCustomgrayModifyResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionCustomgrayModifyResponse : AopResponse
    {
        /// <summary>
        /// 组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
