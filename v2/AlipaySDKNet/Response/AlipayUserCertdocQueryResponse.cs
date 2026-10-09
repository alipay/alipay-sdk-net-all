using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertdocQueryResponse.
    /// </summary>
    public class AlipayUserCertdocQueryResponse : AopResponse
    {
        /// <summary>
        /// 进行授权的用户本人的驾驶证信息
        /// </summary>
        [XmlElement("driving_license")]
        public AlipayUserCertDocDrivingLicense DrivingLicense { get; set; }

        /// <summary>
        /// 所有驾驶证信息列表
        /// </summary>
        [XmlArray("driving_license_list")]
        [XmlArrayItem("alipay_user_cert_doc_driving_license")]
        public List<AlipayUserCertDocDrivingLicense> DrivingLicenseList { get; set; }

        /// <summary>
        /// 进行授权的用户本人的身份证信息
        /// </summary>
        [XmlElement("identity_card")]
        public AlipayUserCertDocIDCard IdentityCard { get; set; }

        /// <summary>
        /// 所有身份证信息列表
        /// </summary>
        [XmlArray("identity_card_list")]
        [XmlArrayItem("alipay_user_cert_doc_i_d_card")]
        public List<AlipayUserCertDocIDCard> IdentityCardList { get; set; }

        /// <summary>
        /// 护照列表
        /// </summary>
        [XmlArray("passport_list")]
        [XmlArrayItem("alipay_user_cert_doc_passport")]
        public List<AlipayUserCertDocPassport> PassportList { get; set; }

        /// <summary>
        /// 进行授权的用户本人的行驶证信息列表
        /// </summary>
        [XmlArray("self_vehicle_license_list")]
        [XmlArrayItem("alipay_user_cert_doc_vehicle_license")]
        public List<AlipayUserCertDocVehicleLicense> SelfVehicleLicenseList { get; set; }

        /// <summary>
        /// 所有行驶证信息列表
        /// </summary>
        [XmlArray("vehicle_license_list")]
        [XmlArrayItem("alipay_user_cert_doc_vehicle_license")]
        public List<AlipayUserCertDocVehicleLicense> VehicleLicenseList { get; set; }
    }
}
