using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FeeDetail : AopObject
    {
        /// <summary>
        /// 费用金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 费用描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("extend_info")]
        [XmlArrayItem("robo_extend_info")]
        public List<RoboExtendInfo> ExtendInfo { get; set; }

        /// <summary>
        /// 费用类型 101:起步费  102:里程费  103:时长费  105:远途费 114:渠道优惠 115:一口价 当type为1时：key有distance、duration； 当type为2时：key有distance； 当type为3时：key有duration； 当type为4时：key有distance； 当type为5时：没有key
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
