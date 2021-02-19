using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FunctionalService Data Structure.
    /// </summary>
    [Serializable]
    public class FunctionalService : AopObject
    {
        /// <summary>
        /// 功能内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 功能码 支持的功能码请与产品或对应技术确认
        /// </summary>
        [XmlElement("function_code")]
        public string FunctionCode { get; set; }

        /// <summary>
        /// 功能名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 功能类型
        /// </summary>
        [XmlElement("function_type")]
        public string FunctionType { get; set; }

        /// <summary>
        /// 功能入口
        /// </summary>
        [XmlElement("function_url")]
        public string FunctionUrl { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
