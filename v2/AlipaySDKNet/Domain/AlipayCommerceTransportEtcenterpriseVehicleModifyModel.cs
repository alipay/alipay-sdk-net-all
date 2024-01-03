using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseVehicleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseVehicleModifyModel : AopObject
    {
        /// <summary>
        /// 经办人证件号
        /// </summary>
        [XmlElement("agent_cert_no")]
        public string AgentCertNo { get; set; }

        /// <summary>
        /// 经办人证件类型 101-身份证
        /// </summary>
        [XmlElement("agent_cert_type")]
        public string AgentCertType { get; set; }

        /// <summary>
        /// 经办人姓名
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 支付宝企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 企业侧车辆编号
        /// </summary>
        [XmlElement("corp_vehicle_id")]
        public string CorpVehicleId { get; set; }

        /// <summary>
        /// ETC办理车辆信息
        /// </summary>
        [XmlElement("vehicle_info")]
        public EtcVehicleInfo VehicleInfo { get; set; }

        /// <summary>
        /// ETC办理车主信息
        /// </summary>
        [XmlElement("vehicle_owner_info")]
        public EtcVehicleOwnerInfo VehicleOwnerInfo { get; set; }
    }
}
