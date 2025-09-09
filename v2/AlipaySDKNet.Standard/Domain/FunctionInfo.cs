using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FunctionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FunctionInfo : AopObject
    {
        /// <summary>
        /// 云函数描述
        /// </summary>
        [XmlElement("function_description")]
        public string FunctionDescription { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [XmlElement("version_description")]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [XmlElement("version_name")]
        public string VersionName { get; set; }
    }
}
