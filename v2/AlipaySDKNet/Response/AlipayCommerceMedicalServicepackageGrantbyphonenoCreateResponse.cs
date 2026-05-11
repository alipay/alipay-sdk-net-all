using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphonenoCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalServicepackageGrantbyphonenoCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一单号
        /// </summary>
        [XmlElement("unique_biz_no")]
        public string UniqueBizNo { get; set; }
    }
}
