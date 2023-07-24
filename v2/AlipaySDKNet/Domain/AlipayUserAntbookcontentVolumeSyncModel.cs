using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbookcontentVolumeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbookcontentVolumeSyncModel : AopObject
    {
        /// <summary>
        /// 书籍ID，可唯一标识一个书籍
        /// </summary>
        [XmlElement("book_id")]
        public string BookId { get; set; }

        /// <summary>
        /// 卷创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 卷名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作类型 ADD：新增操作 UPDATE：更新操作
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 卷排序序号
        /// </summary>
        [XmlElement("sort_no")]
        public long SortNo { get; set; }

        /// <summary>
        /// 卷更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 卷ID，可唯一标识一个卷
        /// </summary>
        [XmlElement("volume_id")]
        public string VolumeId { get; set; }
    }
}
