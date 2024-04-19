using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanPauseResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasPutplanPauseResponse : AopResponse
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 暂停操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
