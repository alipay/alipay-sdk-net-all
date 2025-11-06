using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmCarOwnerNotifyContent Data Structure.
    /// </summary>
    [Serializable]
    public class ZmCarOwnerNotifyContent : AopObject
    {
        /// <summary>
        /// 芝麻车主名片驾驶证信息
        /// </summary>
        [XmlElement("driving_license_info")]
        public ZmCarOwnerDrivingLicenseInfo DrivingLicenseInfo { get; set; }

        /// <summary>
        /// 用户身份信息
        /// </summary>
        [XmlElement("identity_info")]
        public ZmCarOwnerIdentityInfo IdentityInfo { get; set; }

        /// <summary>
        /// 是否开通成功
        /// </summary>
        [XmlElement("open_status")]
        public bool OpenStatus { get; set; }

        /// <summary>
        /// 芝麻车主名片车辆信息列表
        /// </summary>
        [XmlArray("vehicle_info_list")]
        [XmlArrayItem("zm_car_owner_vehicle_info")]
        public List<ZmCarOwnerVehicleInfo> VehicleInfoList { get; set; }
    }
}
