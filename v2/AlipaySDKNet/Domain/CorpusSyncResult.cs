using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpusSyncResult Data Structure.
    /// </summary>
    [Serializable]
    public class CorpusSyncResult : AopObject
    {
        /// <summary>
        /// 异常数量
        /// </summary>
        [XmlElement("exception_count")]
        public string ExceptionCount { get; set; }

        /// <summary>
        /// 描述知识同步的备注信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 知识同步成功的数量
        /// </summary>
        [XmlElement("insert_count")]
        public long InsertCount { get; set; }

        /// <summary>
        /// 修改成功的数量
        /// </summary>
        [XmlElement("modified_count")]
        public long ModifiedCount { get; set; }
    }
}
