using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdTagCreateResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasCrowdTagCreateResponse : AopResponse
    {
        /// <summary>
        /// 人群ID+唯一
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }
    }
}
