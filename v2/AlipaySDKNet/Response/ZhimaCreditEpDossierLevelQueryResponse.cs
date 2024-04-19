using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierLevelQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierLevelQueryResponse : AopResponse
    {
        /// <summary>
        /// 信用等级
        /// </summary>
        [XmlElement("credit_level")]
        public string CreditLevel { get; set; }

        /// <summary>
        /// 评估信用等级时间
        /// </summary>
        [XmlElement("evaluate_time")]
        public string EvaluateTime { get; set; }

        /// <summary>
        /// 是否授权
        /// </summary>
        [XmlElement("has_authed")]
        public bool HasAuthed { get; set; }
    }
}
