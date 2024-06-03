using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdExportData Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdExportData : AopObject
    {
        /// <summary>
        /// 人群的业务日期
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 导出说明信息，包含渠道解释
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 人群唯一键
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 导出的渠道类型
        /// </summary>
        [XmlElement("export_channel_type")]
        public string ExportChannelType { get; set; }

        /// <summary>
        /// 导出OSS的bucket
        /// </summary>
        [XmlElement("oss_bucket")]
        public string OssBucket { get; set; }

        /// <summary>
        /// 导出OSS文件的PATH
        /// </summary>
        [XmlElement("oss_path")]
        public string OssPath { get; set; }

        /// <summary>
        /// 导出任务的唯一流水号
        /// </summary>
        [XmlElement("uniq_biz_id")]
        public string UniqBizId { get; set; }

        /// <summary>
        /// 人群的数量
        /// </summary>
        [XmlElement("user_count")]
        public string UserCount { get; set; }
    }
}
