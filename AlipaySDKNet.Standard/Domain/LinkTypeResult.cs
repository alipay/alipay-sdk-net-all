using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LinkTypeResult Data Structure.
    /// </summary>
    [Serializable]
    public class LinkTypeResult : AopObject
    {
        /// <summary>
        /// 层级
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 环节code
        /// </summary>
        [XmlElement("link_type_code")]
        public string LinkTypeCode { get; set; }

        /// <summary>
        /// 环节名称
        /// </summary>
        [XmlElement("link_type_name")]
        public string LinkTypeName { get; set; }

        /// <summary>
        /// 父环节code，当是一级环节时该参数为空
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
