using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotbspFwjnfcSyncResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorIotbspFwjnfcSyncResponse : AopResponse
    {
        /// <summary>
        /// NFC烧录url
        /// </summary>
        [XmlElement("data")]
        public NfcFWJCommonResult Data { get; set; }

        /// <summary>
        /// 返回NFC烧录链接
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
