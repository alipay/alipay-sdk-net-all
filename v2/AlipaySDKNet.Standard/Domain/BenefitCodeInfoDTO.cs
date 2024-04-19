using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitCodeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitCodeInfoDTO : AopObject
    {
        /// <summary>
        /// 码值文件在oss中的key;secret_voucher_type==CODE_POOL时必填
        /// </summary>
        [XmlElement("secret_voucher_file_key")]
        public string SecretVoucherFileKey { get; set; }

        /// <summary>
        /// 一人多码的码值,secret_voucher_type==GENERAL_CODE时必填
        /// </summary>
        [XmlElement("secret_voucher_general_code")]
        public string SecretVoucherGeneralCode { get; set; }

        /// <summary>
        /// 码值展示样式;BARCODE：条形码;QRCODE ： 二维码;TEXT : 直接展示码值
        /// </summary>
        [XmlElement("secret_voucher_style")]
        public string SecretVoucherStyle { get; set; }

        /// <summary>
        /// GENERAL_CODE ： 通用码，所有人共用同一个码值，多人一码; CODE_POOL ： 码池，一人一码，发码时随机从码池中取一个码值给用户
        /// </summary>
        [XmlElement("secret_voucher_type")]
        public string SecretVoucherType { get; set; }
    }
}
