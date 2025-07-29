using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNdeviceWorkstatusQueryResponse.
    /// </summary>
    public class AlipayOpenSpNdeviceWorkstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备绑定状态，true表示当前设备已经绑定，false表示当前设备维未绑定
        /// </summary>
        [XmlElement("bind_status")]
        public bool BindStatus { get; set; }

        /// <summary>
        /// 碰一下设备SN标识
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备类型，主要描述当前碰一下设备类型，如N6E
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 支付宝侧门店leadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 操作人未脱敏支付宝登记的电话号码 - 绑定场景为作业人员电话号码 - 内部解绑场景为空 - 产品层解绑场景为解绑操作人员电话号码
        /// </summary>
        [XmlElement("operator_contact_number")]
        public string OperatorContactNumber { get; set; }

        /// <summary>
        /// 操作人未脱敏名称 - 绑定场景为作业人员名称 - 内部解绑场景为SYSTEM - 产品层解绑场景为解绑操作人员名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 外部门店编号，门店leads上报时的外部门店编号
        /// </summary>
        [XmlElement("out_store_id")]
        public string OutStoreId { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 关联设备sn唯一标识
        /// </summary>
        [XmlElement("related_device_sn")]
        public string RelatedDeviceSn { get; set; }
    }
}
