using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UnitTraffic Data Structure.
    /// </summary>
    [Serializable]
    public class UnitTraffic : AopObject
    {
        /// <summary>
        /// 灰度人群id，对应人群平台的id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 人群配比，单位是比例，比如1表示1%
        /// </summary>
        [XmlElement("crowd_percent")]
        public long CrowdPercent { get; set; }

        /// <summary>
        /// 分表位起始，0-99表示 最小分表位为0，最大分表位是99，包含了100个分表位都在该分组
        /// </summary>
        [XmlElement("id_range")]
        public string IdRange { get; set; }

        /// <summary>
        /// 单元化标志，是单元的意思，不是单位 由三部分组成，dc1表示机房1，g1表示灰度，trade表示系统
        /// </summary>
        [XmlElement("unit_key")]
        public string UnitKey { get; set; }
    }
}
