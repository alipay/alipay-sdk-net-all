using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConvertedEventGrpDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ConvertedEventGrpDetail : AopObject
    {
        /// <summary>
        /// 转化基础信息列表
        /// </summary>
        [XmlArray("converted_event_detail_list")]
        [XmlArrayItem("converted_event_detail")]
        public List<ConvertedEventDetail> ConvertedEventDetailList { get; set; }

        /// <summary>
        /// 转化分层
        /// </summary>
        [XmlElement("converted_event_grp")]
        public string ConvertedEventGrp { get; set; }

        /// <summary>
        /// 转化分层名称
        /// </summary>
        [XmlElement("converted_event_grp_name")]
        public string ConvertedEventGrpName { get; set; }
    }
}
