using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelLockerAuthSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelLockerAuthSyncModel : AopObject
    {
        /// <summary>
        /// 服务商auhtId，一次授权保证唯一，如果一次授权多个设备权限，需要在auth_id内部拼接
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备服务商code
        /// </summary>
        [XmlElement("device_isv_code")]
        public string DeviceIsvCode { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 默认true有效，用户权限在有效期内失效传入false
        /// </summary>
        [XmlElement("effective")]
        public bool Effective { get; set; }

        /// <summary>
        /// 权限生效截止时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 权限同步服务商Code
        /// </summary>
        [XmlElement("operators_code")]
        public string OperatorsCode { get; set; }

        /// <summary>
        /// 所属集团code
        /// </summary>
        [XmlElement("org_group_code")]
        public string OrgGroupCode { get; set; }

        /// <summary>
        /// 权限生效开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 根据user_relate_type传值
        /// </summary>
        [XmlElement("user_relate_id")]
        public string UserRelateId { get; set; }

        /// <summary>
        /// MOBILE,MEMBER_ID，OPEN_ID三选一
        /// </summary>
        [XmlElement("user_relate_type")]
        public string UserRelateType { get; set; }
    }
}
