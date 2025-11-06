using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerZmcardCarownerQueryResponse.
    /// </summary>
    public class ZhimaCustomerZmcardCarownerQueryResponse : AopResponse
    {
        /// <summary>
        /// 车主名片驾驶证信息
        /// </summary>
        [XmlElement("driving_license_info")]
        public ZmCarOwnerDrivingLicenseInfo DrivingLicenseInfo { get; set; }

        /// <summary>
        /// 车主名片用户身份信息
        /// </summary>
        [XmlElement("identity_info")]
        public ZmCarOwnerIdentityInfo IdentityInfo { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 车主名片车辆信息列表
        /// </summary>
        [XmlArray("vehicle_info_list")]
        [XmlArrayItem("zm_car_owner_vehicle_info")]
        public List<ZmCarOwnerVehicleInfo> VehicleInfoList { get; set; }
    }
}
