using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdOdpsCreateResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasCrowdOdpsCreateResponse : AopResponse
    {
        /// <summary>
        /// 人群ID
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }
    }
}
