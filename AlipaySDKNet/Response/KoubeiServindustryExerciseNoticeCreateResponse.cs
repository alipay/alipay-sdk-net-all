using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseNoticeCreateResponse.
    /// </summary>
    public class KoubeiServindustryExerciseNoticeCreateResponse : AopResponse
    {
        /// <summary>
        /// 通知ID
        /// </summary>
        [XmlElement("notice_id")]
        public string NoticeId { get; set; }
    }
}
