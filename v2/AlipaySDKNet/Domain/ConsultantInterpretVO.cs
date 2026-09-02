using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultantInterpretVO Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultantInterpretVO : AopObject
    {
        /// <summary>
        /// 解读正文 Markdown
        /// </summary>
        [XmlElement("content_md")]
        public string ContentMd { get; set; }

        /// <summary>
        /// 解读创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 解读完成时间（status=SUCCESS 时有值）
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 解读业务ID
        /// </summary>
        [XmlElement("interp_biz_id")]
        public string InterpBizId { get; set; }

        /// <summary>
        /// 解读状态：INIT(生成中) / SUCCESS(已发布) / FAILED(失败/已撤回/已删除)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 解读摘要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 解读标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
