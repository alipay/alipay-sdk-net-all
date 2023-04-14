using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdLogicalCreateResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasCrowdLogicalCreateResponse : AopResponse
    {
        /// <summary>
        /// 人群ID+唯一
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }
    }
}
