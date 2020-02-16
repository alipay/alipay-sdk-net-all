using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryCampSubmitModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
