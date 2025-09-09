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
        /// 物料编号，若和碰一下链接同时传入，以物料编号为准
        /// </summary>
        [XmlArray("cloi_no")]
        [XmlArrayItem("string")]
        public List<string> CloiNo { get; set; }

        /// <summary>
        /// 除物料编号外其他支持绑定的物料绑定参数，现支持碰一下链接绑定，都存在时已物料编号为绑定条件
        /// </summary>
        [XmlElement("ext_param")]
        public NOrderTagBindResp ExtParam { get; set; }

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
