using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceMessageQueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceMessageQueryResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS:标识发送成功。 FAIL:标识发送失败。
        /// </summary>
        [XmlElement("send_status")]
        public string SendStatus { get; set; }

        /// <summary>
        /// 机构消息编号，APPID下唯一。
        /// </summary>
        [XmlElement("uuid")]
        public string Uuid { get; set; }
    }
}
