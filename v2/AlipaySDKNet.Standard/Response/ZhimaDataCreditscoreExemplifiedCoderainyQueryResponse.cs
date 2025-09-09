using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaDataCreditscoreExemplifiedCoderainyQueryResponse.
    /// </summary>
    public class ZhimaDataCreditscoreExemplifiedCoderainyQueryResponse : AopResponse
    {
        /// <summary>
        /// 简单描述
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝的用户id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
