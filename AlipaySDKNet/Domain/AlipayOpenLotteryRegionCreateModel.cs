using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotteryRegionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryRegionCreateModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
