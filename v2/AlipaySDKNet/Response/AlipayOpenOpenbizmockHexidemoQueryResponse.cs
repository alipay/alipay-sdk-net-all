using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOpenbizmockHexidemoQueryResponse.
    /// </summary>
    public class AlipayOpenOpenbizmockHexidemoQueryResponse : AopResponse
    {
        /// <summary>
        /// echo
        /// </summary>
        [XmlElement("echo")]
        public string Echo { get; set; }

        /// <summary>
        /// 调用信息
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 示例结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
