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
        /// 设备ID，设备进件接口同步过来表示系统中设备唯一的逻辑ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备服务商code,在方案接入时分配的表示设备服务商身份的code
        /// </summary>
        [XmlElement("device_isv_code")]
        public string DeviceIsvCode { get; set; }

        /// <summary>
        /// NFC设备编号 无源NFC：线圈ID 有源NFC：mac地址去冒号（来自线圈链接中的内容）
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
        /// 权限同步服务商Code，在方案接入时配置表明服务商身份的code
        /// </summary>
        [XmlElement("operators_code")]
        public string OperatorsCode { get; set; }

        /// <summary>
        /// 所属集团code，集团信息进件接口同步对应的code
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
        /// MOBILE,MEMBER_ID，OPEN_ID，USER_ID四选一
        /// </summary>
        [XmlElement("user_relate_type")]
        public string UserRelateType { get; set; }
    }
}
