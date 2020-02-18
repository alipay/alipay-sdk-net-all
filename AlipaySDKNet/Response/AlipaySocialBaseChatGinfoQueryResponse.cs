using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGinfoQueryResponse.
    /// </summary>
    public class AlipaySocialBaseChatGinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 群信息
        /// </summary>
        [XmlElement("group_info")]
        public GroupInfo GroupInfo { get; set; }

        /// <summary>
        /// 群成员信息列表
        /// </summary>
        [XmlArray("member_infos")]
        [XmlArrayItem("member_info")]
        public List<MemberInfo> MemberInfos { get; set; }
    }
}
