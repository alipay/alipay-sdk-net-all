using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierQrcodeApplyResponse.
    /// </summary>
    public class ZhimaCreditEpDossierQrcodeApplyResponse : AopResponse
    {
        /// <summary>
        /// 二维码到期时间， 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("expiration_time")]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// 企业档案页二维码图片地址
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }
    }
}
