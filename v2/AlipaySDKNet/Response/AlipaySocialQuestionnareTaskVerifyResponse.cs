using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialQuestionnareTaskVerifyResponse.
    /// </summary>
    public class AlipaySocialQuestionnareTaskVerifyResponse : AopResponse
    {
        /// <summary>
        /// 业务扩展字段JSON格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

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

        /// <summary>
        /// 测试结果
        /// </summary>
        [XmlElement("verify_result")]
        public string VerifyResult { get; set; }
    }
}
