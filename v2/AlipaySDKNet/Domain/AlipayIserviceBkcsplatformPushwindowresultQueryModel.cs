using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceBkcsplatformPushwindowresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceBkcsplatformPushwindowresultQueryModel : AopObject
    {
        /// <summary>
        /// 方舟工作台服务请求号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 推屏唯一token
        /// </summary>
        [XmlElement("request_token")]
        public string RequestToken { get; set; }
    }
}
