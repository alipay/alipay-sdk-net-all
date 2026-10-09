using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGroupsQueryResponse.
    /// </summary>
    public class AlipaySocialBaseChatGroupsQueryResponse : AopResponse
    {
        /// <summary>
        /// 群信息列表
        /// </summary>
        [XmlArray("group_infos")]
        [XmlArrayItem("group_info")]
        public List<GroupInfo> GroupInfos { get; set; }

        /// <summary>
        /// 是否有更多
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 同步的key，下一次分页获取使用
        /// </summary>
        [XmlElement("last_key")]
        public long LastKey { get; set; }
    }
}
