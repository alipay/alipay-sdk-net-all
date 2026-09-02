using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIRetailRiskKeyEvent Data Structure.
    /// </summary>
    [Serializable]
    public class AIRetailRiskKeyEvent : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("actions")]
        [XmlArrayItem("string")]
        public List<string> Actions { get; set; }

        /// <summary>
        /// 摄像头id
        /// </summary>
        [XmlElement("camera_id")]
        public string CameraId { get; set; }

        /// <summary>
        /// 触发事件的时间戳
        /// </summary>
        [XmlElement("start_ts")]
        public long StartTs { get; set; }
    }
}
