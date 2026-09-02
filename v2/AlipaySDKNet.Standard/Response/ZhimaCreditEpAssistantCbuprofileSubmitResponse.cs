using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAssistantCbuprofileSubmitResponse.
    /// </summary>
    public class ZhimaCreditEpAssistantCbuprofileSubmitResponse : AopResponse
    {
        /// <summary>
        /// 用户画像记录ID
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
