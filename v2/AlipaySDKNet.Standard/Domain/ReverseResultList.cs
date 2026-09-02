using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReverseResultList Data Structure.
    /// </summary>
    [Serializable]
    public class ReverseResultList : AopObject
    {
        /// <summary>
        /// 对应入参的 data_id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 该条记录删除是否成功（NOT_FOUND 视为 true，删除异常为 false）
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 该条记录结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
