using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFulfillmenttransitCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceFulfillmenttransitCancelResponse : AopResponse
    {
        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("result_data")]
        public bool ResultData { get; set; }
    }
}
