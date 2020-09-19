using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskQueryResponse.
    /// </summary>
    public class AlipaySocialQuestionnareTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 投放渠道
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 接入方式{1:SDK；2:体验检测；3:页面到达;4:页面停留;5:页面返回;6:页面折返;7:用户操作行为}
        /// </summary>
        [XmlElement("collection_type")]
        public string CollectionType { get; set; }

        /// <summary>
        /// 业务扩展信息JSON格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("gmt_terminate")]
        public string GmtTerminate { get; set; }

        /// <summary>
        /// 内灰比例
        /// </summary>
        [XmlElement("gray_percent")]
        public string GrayPercent { get; set; }

        /// <summary>
        /// 交互模式
        /// </summary>
        [XmlElement("interact_type")]
        public string InteractType { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [XmlElement("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// 问卷状态
        /// </summary>
        [XmlElement("qstn_status")]
        public string QstnStatus { get; set; }

        /// <summary>
        /// uone问卷id
        /// </summary>
        [XmlElement("rmt_qstn_id")]
        public string RmtQstnId { get; set; }

        /// <summary>
        /// 问卷URL
        /// </summary>
        [XmlElement("rmt_qstn_url")]
        public string RmtQstnUrl { get; set; }
    }
}
