using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutProductSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtPunchoutProductSyncModel : AopObject
    {
        /// <summary>
        /// access_product_dtos,用于punchout模式产品同步
        /// </summary>
        [XmlArray("access_product_dtos")]
        [XmlArrayItem("punchout_access_product_d_t_o")]
        public List<PunchoutAccessProductDTO> AccessProductDtos { get; set; }
    }
}
