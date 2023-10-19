using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeCreateCustomerChannelAccountResponse Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeCreateCustomerChannelAccountResponse : AopObject
    {
        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 客户渠道账号ID
        /// </summary>
        [XmlElement("channel_uid")]
        public string ChannelUid { get; set; }

        /// <summary>
        /// 客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 海图系统自增ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
