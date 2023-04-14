using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftUpgradeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftUpgradeModel : AopObject
    {
        /// <summary>
        /// 补充证件图片，与additional_cert_no+additional_cert_type搭配使用。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key
        /// </summary>
        [XmlElement("additional_cert_image")]
        public string AdditionalCertImage { get; set; }

        /// <summary>
        /// 补充证件号，与additional_cert_type+additional_cert_image同时提供。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入本字段。
        /// </summary>
        [XmlElement("additional_cert_no")]
        public string AdditionalCertNo { get; set; }

        /// <summary>
        /// 补充证件类型，与additional_cert_no+additional_cert_image搭配使用。可选值有201（营业执照号）、204（民办非企业登记证书）、206（社会团体法人登记证书）、218（事业单位法人证书）、219（党政机关批准设立文件/行政执法主体资格证）。当商户类型为个人时，使用当面付收款有限额，补充这组证件信息可提额。目前仅允许个人类型商户传入本字段。
        /// </summary>
        [XmlElement("additional_cert_type")]
        public string AdditionalCertType { get; set; }

        /// <summary>
        /// 二级商户支付宝商户号，进件成功时由支付宝返回。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
