using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphoneCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalServicepackageGrantbyphoneCreateResponse : AopResponse
    {
        /// <summary>
        /// 服务包订单号
        /// </summary>
        [XmlElement("unique_biz_no")]
        public string UniqueBizNo { get; set; }
    }
}
