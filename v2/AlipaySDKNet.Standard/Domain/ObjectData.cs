using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjectData Data Structure.
    /// </summary>
    [Serializable]
    public class ObjectData : AopObject
    {
        /// <summary>
        /// 智能拓客系统查询返回的数据ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 返回的字段名与字段值信息
        /// </summary>
        [XmlElement("fields")]
        public string Fields { get; set; }

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
    }
}
