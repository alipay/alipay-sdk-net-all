using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcConferenceAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcConferenceAcceptModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("request_data")]
        public string RequestData { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
