using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChinaMobileOutBody Data Structure.
    /// </summary>
    [Serializable]
    public class ChinaMobileOutBody : AopObject
    {
        /// <summary>
        /// 返回数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 移动核销结果错误码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
