using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoNfcCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoNfcCheckModel : AopObject
    {
        /// <summary>
        /// nfc线圈的码值token
        /// </summary>
        [XmlElement("nfc_token")]
        public string NfcToken { get; set; }

        /// <summary>
        /// nfc线圈的tagId
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 买家上传的个人收款码链接
        /// </summary>
        [XmlElement("upload_qrcode_url")]
        public string UploadQrcodeUrl { get; set; }
    }
}
