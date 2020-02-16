using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SnApplyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SnApplyInfo : AopObject
    {
        /// <summary>
        /// 唯一id
        /// </summary>
        [XmlElement("apply_id")]
        public long ApplyId { get; set; }

        /// <summary>
        /// 申请单描述
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 生成sn的数据
        /// </summary>
        [XmlElement("sn_count")]
        public long SnCount { get; set; }

        /// <summary>
        /// 申请单状态  -1表示无效 1 表示生成失败 2.申请单生成成功
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
