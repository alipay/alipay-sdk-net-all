using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayExtendParamsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayExtendParamsDTO : AopObject
    {
        /// <summary>
        /// 付款备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
