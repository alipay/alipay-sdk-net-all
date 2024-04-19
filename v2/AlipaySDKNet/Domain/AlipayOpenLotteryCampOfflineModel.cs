using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryCampOfflineModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
