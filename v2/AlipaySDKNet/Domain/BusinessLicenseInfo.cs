using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessLicenseInfo : AopObject
    {
        /// <summary>
        /// 上传非经营者本人（签约账号）的营业执照时必填，填写营业执照法人的手机号
        /// </summary>
        [XmlElement("business_license_mobile")]
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        [XmlElement("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg 传入使用 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("business_license_pic")]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业期限（非长期时需填）
        /// </summary>
        [XmlElement("date_limitation")]
        public string DateLimitation { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        [XmlElement("long_term")]
        public bool LongTerm { get; set; }
    }
}
