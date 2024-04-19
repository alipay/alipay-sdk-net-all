using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandZftChargerelationBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandZftChargerelationBindModel : AopObject
    {
        /// <summary>
        /// 授权函。当商户名与结算卡户名不一致。《说明函》模板参考https://opendocs.alipay.com/open/direct-payment/cg5mkp#%E7%9B%B8%E5%85%B3%E8%B5%84%E6%96%99。涉及外籍法人（这种情况上传任意能证明身份的图片）时必填，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。（商户类型为个体工商户时，本字段仅需上传营业执照非授权函）
        /// </summary>
        [XmlElement("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 记账方smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 目标记账对手方smid
        /// </summary>
        [XmlElement("target_smid")]
        public string TargetSmid { get; set; }
    }
}
