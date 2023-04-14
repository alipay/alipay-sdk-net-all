using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCliveVisitorOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCliveVisitorOfflineModel : AopObject
    {
        /// <summary>
        /// 访客id
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }

        /// <summary>
        /// DT端定义的访客token
        /// </summary>
        [XmlElement("visitor_token")]
        public string VisitorToken { get; set; }
    }
}
