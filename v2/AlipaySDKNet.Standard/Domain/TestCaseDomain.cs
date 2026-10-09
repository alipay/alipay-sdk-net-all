using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TestCaseDomain Data Structure.
    /// </summary>
    [Serializable]
    public class TestCaseDomain : AopObject
    {
        /// <summary>
        /// ISV的测试节点
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 测试用例id
        /// </summary>
        [XmlElement("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 测试集id
        /// </summary>
        [XmlElement("collection_id")]
        public string CollectionId { get; set; }

        /// <summary>
        /// 测试用例描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 测试用例拓展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 测试用例优先级
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }
    }
}
