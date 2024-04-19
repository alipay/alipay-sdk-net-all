using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialUnitModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialUnitModifyResponse : AopResponse
    {
        /// <summary>
        /// 门店修改操作结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
