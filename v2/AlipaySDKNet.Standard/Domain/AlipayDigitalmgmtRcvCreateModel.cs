using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtRcvCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtRcvCreateModel : AopObject
    {
        /// <summary>
        /// 创建rcv参数
        /// </summary>
        [XmlElement("rcv_create_dto")]
        public RcvCreateDto RcvCreateDto { get; set; }
    }
}
