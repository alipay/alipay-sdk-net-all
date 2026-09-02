using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFulfillmenttransitModifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceFulfillmenttransitModifyResponse : AopResponse
    {
        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("result_data")]
        public bool ResultData { get; set; }
    }
}
