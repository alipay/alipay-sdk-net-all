using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntforestBubbleQueryResponse.
    /// </summary>
    public class AlipaySocialAntforestBubbleQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前有多少森林能量可收，为0即无能量可收
        /// </summary>
        [XmlElement("can_collect_energy")]
        public long CanCollectEnergy { get; set; }

        /// <summary>
        /// 是否当前开通森林
        /// </summary>
        [XmlElement("forest_user")]
        public bool ForestUser { get; set; }
    }
}
