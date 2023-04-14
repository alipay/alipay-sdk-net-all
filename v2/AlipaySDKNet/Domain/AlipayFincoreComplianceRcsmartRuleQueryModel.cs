using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartRuleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcsmartRuleQueryModel : AopObject
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
        /// 文件id,审核结果查询返回的file_id。用于查询审核当前文件的所有规则信息
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 请求Id，与app_name组成唯一健，保证审核工单为该调用方所有
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
