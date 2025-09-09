using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogAivisionrecgDeviceoperateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogAivisionrecgDeviceoperateQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁激活码
        /// </summary>
        [XmlElement("activation_code")]
        public string ActivationCode { get; set; }

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
    }
}
