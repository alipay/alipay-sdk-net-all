using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopLifeserviceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopLifeserviceCreateModel : AopObject
    {
        /// <summary>
        /// 商户营业执照信息
        /// </summary>
        [XmlElement("business_license_info")]
        public BusinessLicenseInfo BusinessLicenseInfo { get; set; }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [XmlElement("contact_info")]
        public LifeServiceContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 一体化作业开通主单号，单号为服务商一体化作业主单创建返回值。
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 商家经营类目编码。参见 <a href="https://opendocs.alipay.com/common/02khjv">商家经营类目2.0</a> 中的“一级类目code_二级类目code”。
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("special_license_info")]
        [XmlArrayItem("special_license_info")]
        public List<SpecialLicenseInfo> SpecialLicenseInfo { get; set; }
    }
}
