using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteOpSpecialLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InteOpSpecialLicenseInfo : AopObject
    {
        /// <summary>
        /// 企业特殊资质图片，可参考 商家经营类目 中的“需要的特殊资质证书”。文件最小为 5KB，最大为5M，图片格式必须为：png、bmp、gif、jpg、jpeg。 传入 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("special_license_pic")]
        public string SpecialLicensePic { get; set; }

        /// <summary>
        /// 合约特殊资质的类型，默认可以传99
        /// </summary>
        [XmlElement("special_license_type")]
        public string SpecialLicenseType { get; set; }
    }
}
