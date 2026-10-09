using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FtokenInfoResult Data Structure.
    /// </summary>
    [Serializable]
    public class FtokenInfoResult : AopObject
    {
        /// <summary>
        /// 离线ftoken
        /// </summary>
        [XmlElement("ftoken")]
        public string Ftoken { get; set; }

        /// <summary>
        /// 支付宝账户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝账户uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
