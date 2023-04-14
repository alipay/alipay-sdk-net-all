using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeExpressQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeExpressQueryResponse : AopObject
    {
        /// <summary>
        /// 快递包裹状态
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 包裹数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
