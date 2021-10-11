using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneYebEntityequityVerifyResponse.
    /// </summary>
    public class AntfortuneYebEntityequityVerifyResponse : AopResponse
    {
        /// <summary>
        /// web层返回对象封装
        /// </summary>
        [XmlElement("response")]
        public BaseWebResponse Response { get; set; }
    }
}
