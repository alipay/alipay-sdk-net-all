using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LtOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LtOrderDTO : AopObject
    {
        /// <summary>
        /// 申买/卖量 股票:股 权证:份 债券:手
        /// </summary>
        [XmlElement("volume")]
        public string Volume { get; set; }
    }
}
