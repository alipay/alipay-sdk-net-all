using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParamExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParamExtInfo : AopObject
    {
        /// <summary>
        /// 小程序地址中的参数名称，具体详见接口开发文档
        /// </summary>
        [XmlElement("param_name")]
        public string ParamName { get; set; }

        /// <summary>
        /// 小程序地址中的参数值，具体详见接口开发文档
        /// </summary>
        [XmlElement("param_value")]
        public string ParamValue { get; set; }

        /// <summary>
        /// 小程序地址中的参数类型, start：小程序的启动参数；page：小程序的页面参数。具体详见接口开发文档
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
