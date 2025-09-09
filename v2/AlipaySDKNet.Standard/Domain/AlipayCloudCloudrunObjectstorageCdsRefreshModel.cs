using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageCdsRefreshModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageCdsRefreshModel : AopObject
    {
        /// <summary>
        /// 刷新 URL，格式为加速域名或刷新的文件或目录
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("string")]
        public List<string> Content { get; set; }

        /// <summary>
        /// 小程序云的云托管下对应的环境id，他是以 env开头的随机字符串的形式
        /// </summary>
        [XmlElement("envid")]
        public string Envid { get; set; }

        /// <summary>
        /// 通过这个字段判断是按照操作类型
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作方式，填写支持的操作方式
        /// </summary>
        [XmlElement("operatortype")]
        public string Operatortype { get; set; }
    }
}
