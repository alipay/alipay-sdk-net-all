using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicAuditQueryReq Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicAuditQueryReq : AopObject
    {
        /// <summary>
        /// 服务商负责的景区小程序APPID
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 支付宝景区ID
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }
    }
}
