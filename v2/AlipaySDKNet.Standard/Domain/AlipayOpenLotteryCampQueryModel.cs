using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryCampQueryModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
