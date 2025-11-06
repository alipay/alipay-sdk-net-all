using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuoteTagDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QuoteTagDTO : AopObject
    {
        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("ext_props")]
        public string ExtProps { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标的物id
        /// </summary>
        [XmlElement("obj_id")]
        public string ObjId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("snapshot_date")]
        public long SnapshotDate { get; set; }

        /// <summary>
        /// 标签代码
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
