using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperateFailRes Data Structure.
    /// </summary>
    [Serializable]
    public class OperateFailRes : AopObject
    {
        /// <summary>
        /// 操作失败的创意id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 操作失败原因
        /// </summary>
        [XmlElement("operate_memo")]
        public string OperateMemo { get; set; }
    }
}
