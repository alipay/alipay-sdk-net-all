using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHomedoctorFollowuptaskQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHomedoctorFollowuptaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 任务完成时间，仅当任务完成时才有值
        /// </summary>
        [XmlElement("completed_time")]
        public string CompletedTime { get; set; }

        /// <summary>
        /// AES加密后的内容，指定服务商透出，仅当任务完成时才有值
        /// </summary>
        [XmlElement("conversation_data_encrypted")]
        public string ConversationDataEncrypted { get; set; }

        /// <summary>
        /// 随访会话记录明文SHA256哈希值，仅当任务完成时才有值
        /// </summary>
        [XmlElement("conversation_data_hash")]
        public string ConversationDataHash { get; set; }

        /// <summary>
        /// 加密密钥版本号，仅当任务完成时才有值
        /// </summary>
        [XmlElement("encryption_key_version")]
        public string EncryptionKeyVersion { get; set; }

        /// <summary>
        /// AES加密后的内容，仅当任务完成时才有值
        /// </summary>
        [XmlElement("form_data_encrypted")]
        public string FormDataEncrypted { get; set; }

        /// <summary>
        /// 随访表单内容明文SHA256哈希值，仅当任务完成时才有值
        /// </summary>
        [XmlElement("form_data_hash")]
        public string FormDataHash { get; set; }

        /// <summary>
        /// 随访任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 随访任务状态
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// AI随访模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// AI随访模版名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
