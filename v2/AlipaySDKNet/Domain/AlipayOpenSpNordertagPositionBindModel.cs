using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordertagPositionBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordertagPositionBindModel : AopObject
    {
        /// <summary>
        /// 线圈编号
        /// </summary>
        [XmlArray("cloi_no")]
        [XmlArrayItem("string")]
        public List<string> CloiNo { get; set; }

        /// <summary>
        /// 进行的操作
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 点位唯一标识
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }
    }
}
