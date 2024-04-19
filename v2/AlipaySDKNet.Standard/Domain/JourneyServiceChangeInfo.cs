using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JourneyServiceChangeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class JourneyServiceChangeInfo : AopObject
    {
        /// <summary>
        /// 变更状态
        /// </summary>
        [XmlElement("change_status")]
        public string ChangeStatus { get; set; }

        /// <summary>
        /// 详情url
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 提醒内容
        /// </summary>
        [XmlElement("remind_content")]
        public string RemindContent { get; set; }
    }
}
