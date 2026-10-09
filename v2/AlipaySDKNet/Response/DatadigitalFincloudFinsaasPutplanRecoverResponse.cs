using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanRecoverResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasPutplanRecoverResponse : AopResponse
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 恢复结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
