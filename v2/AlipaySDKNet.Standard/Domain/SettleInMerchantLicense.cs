using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleInMerchantLicense Data Structure.
    /// </summary>
    [Serializable]
    public class SettleInMerchantLicense : AopObject
    {
        /// <summary>
        /// 商户上传资质详情
        /// </summary>
        [XmlArray("common_merchant_licenses")]
        [XmlArrayItem("common_merchant_license")]
        public List<CommonMerchantLicense> CommonMerchantLicenses { get; set; }

        /// <summary>
        /// 商户二级类目code
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 商户简称。用于芝麻信用服务开通。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
