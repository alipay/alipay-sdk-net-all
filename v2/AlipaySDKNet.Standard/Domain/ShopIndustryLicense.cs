using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopIndustryLicense Data Structure.
    /// </summary>
    [Serializable]
    public class ShopIndustryLicense : AopObject
    {
        /// <summary>
        /// 资质图片信息
        /// </summary>
        [XmlElement("license_pic")]
        public string LicensePic { get; set; }

        /// <summary>
        /// 行业资质类型，需使用<a href="https://mdn.alipayobjects.com/mrcheshop/afts/file/iGfGQL0ATkEAAAAAAAAAAAAADiWmAQBr?af_fileName=%E8%B5%84%E8%B4%A8%E7%B1%BB%E5%9E%8B.xlsx">资质列表</a>中类型
        /// </summary>
        [XmlElement("license_type")]
        public string LicenseType { get; set; }
    }
}
