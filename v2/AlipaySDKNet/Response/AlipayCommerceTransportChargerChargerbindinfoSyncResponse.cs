using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerChargerbindinfoSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerChargerbindinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 商户同步的充电桩设备编码
        /// </summary>
        [XmlElement("equip_id")]
        public string EquipId { get; set; }

        /// <summary>
        /// 绑定关系结果接收失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 0：成功 1：拒绝
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }
    }
}
