using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshEventTracking Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshEventTracking : AopObject
    {
        /// <summary>
        /// 埋点海报氛围
        /// </summary>
        [XmlElement("atmosphere")]
        public string Atmosphere { get; set; }

        /// <summary>
        /// 设备业务标识，按设备授权控制可见性
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 当前关联活动标识
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("camp_ids")]
        [XmlArrayItem("string")]
        public List<string> CampIds { get; set; }

        /// <summary>
        /// 关联活动来源类型
        /// </summary>
        [XmlElement("camp_type")]
        public string CampType { get; set; }

        /// <summary>
        /// 埋点海报类型，固定为REDUCE_PROCESS_POSTER
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 命中的海报计划标识
        /// </summary>
        [XmlElement("scheme_id")]
        public string SchemeId { get; set; }

        /// <summary>
        /// 海报计划中的设备界面类型，取值随设备型号配置变化
        /// </summary>
        [XmlElement("ui_type")]
        public string UiType { get; set; }
    }
}
