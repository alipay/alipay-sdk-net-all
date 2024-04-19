using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainEcsealApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlegalchainEcsealApplyModel : AopObject
    {
        /// <summary>
        /// 发起签约接口返回的baseDataId
        /// </summary>
        [XmlElement("bas_data_id")]
        public string BasDataId { get; set; }

        /// <summary>
        /// 业务数据请求唯一标识，需要保证唯一性
        /// </summary>
        [XmlElement("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 用于标识某个文件
        /// </summary>
        [XmlElement("file_uniq_id")]
        public string FileUniqId { get; set; }

        /// <summary>
        /// 通知人邮箱地址列表
        /// </summary>
        [XmlArray("notify_emails")]
        [XmlArrayItem("string")]
        public List<string> NotifyEmails { get; set; }

        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [XmlElement("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [XmlElement("request_time_stamp")]
        public string RequestTimeStamp { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 任务owner通知邮箱
        /// </summary>
        [XmlElement("task_owner_email")]
        public string TaskOwnerEmail { get; set; }

        /// <summary>
        /// 任务owner姓名
        /// </summary>
        [XmlElement("task_owner_name")]
        public string TaskOwnerName { get; set; }

        /// <summary>
        /// 任务owner工号
        /// </summary>
        [XmlElement("task_owner_no")]
        public string TaskOwnerNo { get; set; }
    }
}
