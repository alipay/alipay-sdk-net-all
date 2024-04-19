using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotteryRegionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryRegionModifyModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
