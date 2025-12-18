using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecialLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpecialLicenseInfo : AopObject
    {
        /// <summary>
        /// 【描述】企业特殊资质图片，可参考 商家经营类目 中的“需要的特殊资质证书”。 【必选条件】根据商家类目判断是否需要资质，资质信息见 商家经营类目2.0。 传入使用 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("special_license_pic")]
        public string SpecialLicensePic { get; set; }

        /// <summary>
        /// 长度范围：[0,100] 枚举值： 门头照:101 内景照片:102 办公场地照片:103 商户码照片:104 收费样本:105 店内照:106 门头照:107 经营场景照:108 门店分发封面图:109 商圈相册:110 其他附件:99
        /// </summary>
        [XmlElement("special_license_type")]
        public string SpecialLicenseType { get; set; }
    }
}
