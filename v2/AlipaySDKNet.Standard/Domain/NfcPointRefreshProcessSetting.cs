using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NfcPointRefreshProcessSetting Data Structure.
    /// </summary>
    [Serializable]
    public class NfcPointRefreshProcessSetting : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("show_times")]
        [XmlArrayItem("nfc_point_refresh_show_time")]
        public List<NfcPointRefreshShowTime> ShowTimes { get; set; }

        /// <summary>
        /// 进度展示方式：percent为百分比，count为份数
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }
    }
}
