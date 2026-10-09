using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FtokenInfoQuery Data Structure.
    /// </summary>
    [Serializable]
    public class FtokenInfoQuery : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 业务唯一标识id
        /// </summary>
        [XmlElement("bizid")]
        public string Bizid { get; set; }

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
