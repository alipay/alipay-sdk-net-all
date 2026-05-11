using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceRightsCheckResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceRightsCheckResponse : AopResponse
    {
        /// <summary>
        /// 结果数据
        /// </summary>
        [XmlElement("rights_result")]
        public RightsResult RightsResult { get; set; }
    }
}
