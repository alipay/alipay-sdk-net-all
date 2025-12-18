using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboFeeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RoboFeeDetail : AopObject
    {
        /// <summary>
        /// 费用金额 单位 分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 费用描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 费用类型 101:起步费  102:里程费  103:时长费  105:远途费 114:渠道优惠 115:一口价 116:过路费 117:低速时长费
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
