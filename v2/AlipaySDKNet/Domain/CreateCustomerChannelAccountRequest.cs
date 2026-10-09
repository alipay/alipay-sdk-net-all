using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreateCustomerChannelAccountRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CreateCustomerChannelAccountRequest : AopObject
    {
        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 客户渠道账号
        /// </summary>
        [XmlElement("channel_uid")]
        public string ChannelUid { get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
