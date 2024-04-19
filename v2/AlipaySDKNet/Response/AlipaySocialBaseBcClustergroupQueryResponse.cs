using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseBcClustergroupQueryResponse.
    /// </summary>
    public class AlipaySocialBaseBcClustergroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 社交聊天群的概要信息
        /// </summary>
        [XmlArray("group_briefs")]
        [XmlArrayItem("group_brief")]
        public List<GroupBrief> GroupBriefs { get; set; }
    }
}
