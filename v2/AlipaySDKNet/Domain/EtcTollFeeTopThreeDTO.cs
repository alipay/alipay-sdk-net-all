using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcTollFeeTopThreeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EtcTollFeeTopThreeDTO : AopObject
    {
        /// <summary>
        /// 通行费金额(元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 占比（小数）
        /// </summary>
        [XmlElement("ratio")]
        public string Ratio { get; set; }
    }
}
