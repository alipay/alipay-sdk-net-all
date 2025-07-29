using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupControlRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupControlRuleVO : AopObject
    {
        /// <summary>
        /// 应用ID列表
        /// </summary>
        [XmlArray("app_id_list")]
        [XmlArrayItem("string")]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// 检测点列表
        /// </summary>
        [XmlArray("check_position_list")]
        [XmlArrayItem("string")]
        public List<string> CheckPositionList { get; set; }

        /// <summary>
        /// 白名单域名列表
        /// </summary>
        [XmlArray("domain_name_white_list")]
        [XmlArrayItem("string")]
        public List<string> DomainNameWhiteList { get; set; }

        /// <summary>
        /// 敏感词列表
        /// </summary>
        [XmlArray("key_word_list")]
        [XmlArrayItem("string")]
        public List<string> KeyWordList { get; set; }

        /// <summary>
        /// 消息类型列表
        /// </summary>
        [XmlArray("msg_type_list")]
        [XmlArrayItem("string")]
        public List<string> MsgTypeList { get; set; }

        /// <summary>
        /// 规则类型
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 时间限制
        /// </summary>
        [XmlElement("time_limit")]
        public string TimeLimit { get; set; }

        /// <summary>
        /// 连发总数
        /// </summary>
        [XmlElement("total_msg_limit")]
        public string TotalMsgLimit { get; set; }
    }
}
