using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommerceDataUploadResponseData Data Structure.
    /// </summary>
    [Serializable]
    public class CommerceDataUploadResponseData : AopObject
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        [XmlElement("response")]
        public string Response { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
