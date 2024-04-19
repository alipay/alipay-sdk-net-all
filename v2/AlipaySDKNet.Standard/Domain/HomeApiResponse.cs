using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HomeApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class HomeApiResponse : AopObject
    {
        /// <summary>
        /// 对应入参的biz_id，全局唯一
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [XmlElement("result_json")]
        public string ResultJson { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
