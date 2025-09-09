using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtendData Data Structure.
    /// </summary>
    [Serializable]
    public class ExtendData : AopObject
    {
        /// <summary>
        /// 医保结算
        /// </summary>
        [XmlElement("mi_settle_ext")]
        public string MiSettleExt { get; set; }
    }
}
