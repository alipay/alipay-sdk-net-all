using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseShopLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseShopLicenseInfo : AopObject
    {
        /// <summary>
        /// 证件到期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 主体证件名称
        /// </summary>
        [XmlElement("license_name")]
        public string LicenseName { get; set; }

        /// <summary>
        /// 主体证件号
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 主体证件图片，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("license_pic")]
        public string LicensePic { get; set; }
    }
}
