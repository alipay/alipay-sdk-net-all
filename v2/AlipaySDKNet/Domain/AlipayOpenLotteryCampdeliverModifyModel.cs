using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampdeliverModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryCampdeliverModifyModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
