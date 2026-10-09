using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScalesActivationCodeDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScalesActivationCodeDeviceInfo : AopObject
    {
        /// <summary>
        /// 蚂蚁激活码
        /// </summary>
        [XmlElement("activation_code")]
        public string ActivationCode { get; set; }

        /// <summary>
        /// 设备激活类型(激活码/设备白名单)
        /// </summary>
        [XmlElement("activation_type")]
        public string ActivationType { get; set; }

        /// <summary>
        /// 蚂蚁IOT机具设备号
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 服务商设备号，mac地址
        /// </summary>
        [XmlElement("isv_tid")]
        public string IsvTid { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }
    }
}
