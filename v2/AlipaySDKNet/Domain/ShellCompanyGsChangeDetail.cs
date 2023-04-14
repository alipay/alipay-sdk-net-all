using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShellCompanyGsChangeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ShellCompanyGsChangeDetail : AopObject
    {
        /// <summary>
        /// 变更后内容
        /// </summary>
        [XmlElement("after_content")]
        public string AfterContent { get; set; }

        /// <summary>
        /// 变更前内容
        /// </summary>
        [XmlElement("before_content")]
        public string BeforeContent { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 空壳企业公司变更标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 变更时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
