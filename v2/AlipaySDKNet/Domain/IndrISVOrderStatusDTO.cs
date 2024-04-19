using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndrISVOrderStatusDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IndrISVOrderStatusDTO : AopObject
    {
        /// <summary>
        /// 错误码 材料审核拒绝时会给出
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息  材料审核拒绝时会给出
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }
    }
}
