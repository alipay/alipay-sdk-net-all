using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortraitInMallReqDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitInMallReqDTO : AopObject
    {
        /// <summary>
        /// 居住人口需要分析的标签； 职业分布TOP10和职业分布TOP50请只选择其中的一个。
        /// </summary>
        [XmlArray("live_user_tag")]
        [XmlArrayItem("string")]
        public List<string> LiveUserTag { get; set; }

        /// <summary>
        /// 常驻人口下需要分析的标签； 职业分布TOP10和职业分布TOP50请只选择其中的一个。
        /// </summary>
        [XmlArray("settled_user_tag")]
        [XmlArrayItem("string")]
        public List<string> SettledUserTag { get; set; }

        /// <summary>
        /// 工作人口下需要分析的标签； 职业分布TOP10和职业分布TOP50请只选择其中的一个。
        /// </summary>
        [XmlArray("work_user_tag")]
        [XmlArrayItem("string")]
        public List<string> WorkUserTag { get; set; }
    }
}
