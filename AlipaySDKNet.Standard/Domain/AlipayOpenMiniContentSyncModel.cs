using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniContentSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniContentSyncModel : AopObject
    {
        /// <summary>
        /// 具体的内容数据，采用json格式，不同类型不同操作数据不同。可参考具体内容接入文档中的详细说明。
        /// </summary>
        [XmlElement("content_data")]
        public string ContentData { get; set; }

        /// <summary>
        /// 内容类型，例如门店、商品等
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 扩展信息，json格式。可参考具体内容接入文档中的详细说明。
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 内容类型下的具体操作，比如门店类型下，小程序批量绑定门店。可参考具体内容接入文档中的详细说明。
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }
    }
}
