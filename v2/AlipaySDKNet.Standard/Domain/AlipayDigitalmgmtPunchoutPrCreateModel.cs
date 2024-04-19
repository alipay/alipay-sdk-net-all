using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutPrCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtPunchoutPrCreateModel : AopObject
    {
        /// <summary>
        /// pur_req,用于下pr单
        /// </summary>
        [XmlElement("pur_req")]
        public MallReceivePrRequest PurReq { get; set; }
    }
}
