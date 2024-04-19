using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialQuestionnareTaskPublishModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [XmlElement("qstn_id")]
        public string QstnId { get; set; }

        /// <summary>
        /// UONE问券ID
        /// </summary>
        [XmlElement("rmt_qstn_id")]
        public string RmtQstnId { get; set; }
    }
}
