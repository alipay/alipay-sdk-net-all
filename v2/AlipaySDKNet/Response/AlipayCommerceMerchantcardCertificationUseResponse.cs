using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardCertificationUseResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardCertificationUseResponse : AopResponse
    {
        /// <summary>
        /// 批量核销结果
        /// </summary>
        [XmlArray("context")]
        [XmlArrayItem("certificate_submit_resonse")]
        public List<CertificateSubmitResonse> Context { get; set; }

        /// <summary>
        /// ture:提交成功 false:提交失败
        /// </summary>
        [XmlElement("res")]
        public bool Res { get; set; }
    }
}
