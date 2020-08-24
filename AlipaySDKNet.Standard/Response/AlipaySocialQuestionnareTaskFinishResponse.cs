using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskFinishResponse.
    /// </summary>
    public class AlipaySocialQuestionnareTaskFinishResponse : AopResponse
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [XmlElement("qstn_id")]
        public string QstnId { get; set; }
    }
}
