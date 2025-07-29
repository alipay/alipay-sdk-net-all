using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupMsgAutoreplyRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupMsgAutoreplyRecordVO : AopObject
    {
        /// <summary>
        /// 自动回复id
        /// </summary>
        [XmlElement("autoreply_id")]
        public string AutoreplyId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 0 删除，2 启用，3 停用
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
