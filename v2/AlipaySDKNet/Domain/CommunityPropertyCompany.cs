using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityPropertyCompany Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityPropertyCompany : AopObject
    {
        /// <summary>
        /// 企业描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 物业公司商标地址
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 物业公司备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 物业公司名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 物业公司Pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 物业小区规模。单位: 个。用于后续消息广播场景根据物业负责小区规模进行分发调度。
        /// </summary>
        [XmlElement("scale")]
        public string Scale { get; set; }

        /// <summary>
        /// 首次调用不传，插入新物业公司信息，并且接口返回该字段。后续更新对应物业公司时传入该字段，更新对应记录信息
        /// </summary>
        [XmlElement("short_name")]
        public string ShortName { get; set; }
    }
}
