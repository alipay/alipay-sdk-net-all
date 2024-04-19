using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelFliggyStoreModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelFliggyStoreModifyModel : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 主体数据
        /// </summary>
        [XmlElement("data")]
        public StoreInfo Data { get; set; }

        /// <summary>
        /// 请求消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
