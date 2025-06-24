using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterCancelorderNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterCancelorderNotifyModel : AopObject
    {
        /// <summary>
        /// 排版下具体号源信息id
        /// </summary>
        [XmlElement("number_no")]
        public string NumberNo { get; set; }

        /// <summary>
        /// 预约订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 号源平台编码
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 第一级排班接口中排班 id. 若有号源ID，需传该字段
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }
    }
}
