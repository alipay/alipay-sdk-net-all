using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankQrcodeCreateResponse.
    /// </summary>
    public class AlipayUserDtbankQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 银行码码值
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 银行码全局唯一Id
        /// </summary>
        [XmlElement("qrcode_id")]
        public string QrcodeId { get; set; }

        /// <summary>
        /// 银行码外部展示Id
        /// </summary>
        [XmlElement("qrcode_out_id")]
        public string QrcodeOutId { get; set; }
    }
}
