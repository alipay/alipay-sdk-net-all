using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FunctionAsyncConfig Data Structure.
    /// </summary>
    [Serializable]
    public class FunctionAsyncConfig : AopObject
    {
        /// <summary>
        /// 失败回调，如回调云函数
        /// </summary>
        [XmlElement("on_failure")]
        public AsyncConfigDestination OnFailure { get; set; }

        /// <summary>
        /// 成功回调，如回调云函数
        /// </summary>
        [XmlElement("on_success")]
        public AsyncConfigDestination OnSuccess { get; set; }
    }
}
