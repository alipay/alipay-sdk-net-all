using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GavinTestnew Data Structure.
    /// </summary>
    [Serializable]
    public class GavinTestnew : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
