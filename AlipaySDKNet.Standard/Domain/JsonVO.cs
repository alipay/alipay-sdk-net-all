using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JsonVO Data Structure.
    /// </summary>
    [Serializable]
    public class JsonVO : AopObject
    {
        /// <summary>
        /// 失败信息
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }
    }
}
