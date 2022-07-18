using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrcampuscoreNiukeexamResultSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrcampuscoreNiukeexamResultSyncModel : AopObject
    {
        /// <summary>
        /// 牛客回调参数请求对象
        /// </summary>
        [XmlElement("niuke_exam_callback_request")]
        public NiukeExamCallbackRequest NiukeExamCallbackRequest { get; set; }
    }
}
