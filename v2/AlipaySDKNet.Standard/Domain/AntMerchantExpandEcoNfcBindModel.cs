using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoNfcBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoNfcBindModel : AopObject
    {
        /// <summary>
        /// 生态电商卖家公司编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

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
