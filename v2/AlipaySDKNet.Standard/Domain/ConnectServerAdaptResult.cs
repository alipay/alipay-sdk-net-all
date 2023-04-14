using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConnectServerAdaptResult Data Structure.
    /// </summary>
    [Serializable]
    public class ConnectServerAdaptResult : AopObject
    {
        /// <summary>
        /// 排队次序
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 是否是人工客服时间
        /// </summary>
        [XmlElement("is_service_time")]
        public bool IsServiceTime { get; set; }

        /// <summary>
        /// 统一portal用排队文案
        /// </summary>
        [XmlElement("portal_msg")]
        public string PortalMsg { get; set; }

        /// <summary>
        /// 访客uid
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }

        /// <summary>
        /// 访客token
        /// </summary>
        [XmlElement("visitor_token")]
        public string VisitorToken { get; set; }

        /// <summary>
        /// 访客类型，COMMON_VISITOR(普通登录访客)/ANONYMITY_VISITOR(匿名访客)
        /// </summary>
        [XmlElement("visitor_type")]
        public string VisitorType { get; set; }

        /// <summary>
        /// 欢迎语
        /// </summary>
        [XmlElement("welcome")]
        public string Welcome { get; set; }
    }
}
