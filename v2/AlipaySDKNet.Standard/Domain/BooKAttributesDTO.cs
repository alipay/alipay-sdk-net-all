using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BooKAttributesDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BooKAttributesDTO : AopObject
    {
        /// <summary>
        /// 投放渠道
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 会话标识
        /// </summary>
        [XmlElement("chat_id")]
        public string ChatId { get; set; }

        /// <summary>
        /// 订单的端标识
        /// </summary>
        [XmlElement("mgw_app_name")]
        public string MgwAppName { get; set; }
    }
}
