using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceQhinsplatSigninModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceQhinsplatSigninModel : AopObject
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        [XmlElement("request_str")]
        public string RequestStr { get; set; }
    }
}
