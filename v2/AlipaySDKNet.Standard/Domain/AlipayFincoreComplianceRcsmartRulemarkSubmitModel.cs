using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartRulemarkSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcsmartRulemarkSubmitModel : AopObject
    {
        /// <summary>
        /// app_name为调用方系统名称(英文)，与分配的app_token一起做调用系统合法性校验
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token为系统分配的密钥，与app_name一起做调用系统合法性校验
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 打标文件id,审核结果查询返回的file_id。
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 请求Id，与app_name组成唯一健，保证审核工单为该调用方所有
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 规则打标返回信息列表
        /// </summary>
        [XmlArray("rule_mark_info_list")]
        [XmlArrayItem("rule_mark_info")]
        public List<RuleMarkInfo> RuleMarkInfoList { get; set; }
    }
}
