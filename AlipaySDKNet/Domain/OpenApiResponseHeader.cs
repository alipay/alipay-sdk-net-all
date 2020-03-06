using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiResponseHeader Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiResponseHeader : AopObject
    {
        /// <summary>
        /// 自定义状态码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [XmlElement("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 子状态码
        /// </summary>
        [XmlElement("sub_status_code")]
        public string SubStatusCode { get; set; }
    }
}
