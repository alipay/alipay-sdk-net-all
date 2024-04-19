using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseVehicleQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcenterpriseVehicleQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝etc平台扣款协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// SUCCESS：成功； FAIL：失败
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 成功/其他业务异常信息描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 代扣签约状态
        /// </summary>
        [XmlElement("deduct_sign_status")]
        public string DeductSignStatus { get; set; }

        /// <summary>
        /// 状态触发的具体时间
        /// </summary>
        [XmlElement("device_biz_time")]
        public string DeviceBizTime { get; set; }

        /// <summary>
        /// 用户ETC设备OBU号
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// USABLE-设备激活可用（可上高速正常使用）PENDING-设备激活挂起（限制消费） UNUSABLE-设备异常不可用
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 设备状态明细，能清楚说明etc设备此时状态（/卡签注销/卡签挂失/已过户/维修中/黑名单/卡过期/欠费/标签脱落/设备报警/正常/ETC停用等）
        /// </summary>
        [XmlElement("device_status_detail")]
        public string DeviceStatusDetail { get; set; }

        /// <summary>
        /// 支付宝侧订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// ORDER_CREATE:订单创建;ORDER_SYNCED:订单已同步;SUCCESS_ACTIVATE:订单已激活;UNMOUNTING:注销中;UNMOUNTED:已注销;
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付宝车辆id
        /// </summary>
        [XmlElement("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
