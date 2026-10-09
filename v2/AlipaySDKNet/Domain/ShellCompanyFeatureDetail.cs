using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShellCompanyFeatureDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ShellCompanyFeatureDetail : AopObject
    {
        /// <summary>
        /// 说明内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 空壳企业特征枚举主标题
        /// </summary>
        [XmlElement("main_title")]
        public string MainTitle { get; set; }

        /// <summary>
        /// 空壳企业特征枚举子标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 更新时间 yyyy-MM-dd
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
