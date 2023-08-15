using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmOlsLeavemessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmOlsLeavemessageQueryModel : AopObject
    {
        /// <summary>
        /// 聊天窗code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 访客id
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }
    }
}
