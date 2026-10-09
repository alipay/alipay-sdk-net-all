using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PassAccountNameHashRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PassAccountNameHashRecordDTO : AopObject
    {
        /// <summary>
        /// account_name
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 冲突类型
        /// </summary>
        [XmlElement("conflict_type")]
        public string ConflictType { get; set; }

        /// <summary>
        /// data_source
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// Unix毫秒
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// name_hash_status
        /// </summary>
        [XmlElement("name_hash_status")]
        public string NameHashStatus { get; set; }

        /// <summary>
        /// 账号记录ID
        /// </summary>
        [XmlElement("pass_account_id")]
        public string PassAccountId { get; set; }

        /// <summary>
        /// 通行证ID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 关联账号名称
        /// </summary>
        [XmlElement("related_account_names")]
        public string RelatedAccountNames { get; set; }

        /// <summary>
        /// 关联账号记录ID
        /// </summary>
        [XmlElement("related_pass_account_ids")]
        public string RelatedPassAccountIds { get; set; }

        /// <summary>
        /// 关联通行证ID
        /// </summary>
        [XmlElement("related_passport_ids")]
        public string RelatedPassportIds { get; set; }

        /// <summary>
        /// 账号状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
