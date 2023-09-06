using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BatchModifyResponse Data Structure.
    /// </summary>
    [Serializable]
    public class BatchModifyResponse : AopObject
    {
        /// <summary>
        /// 数据
        /// </summary>
        [XmlElement("data")]
        public BatchResultDTO Data { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        [XmlElement("response_msg")]
        public string ResponseMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succeeded")]
        public bool Succeeded { get; set; }
    }
}
