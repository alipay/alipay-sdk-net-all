using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiDevicePayCallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiDevicePayCallbackModel : AopObject
    {
        /// <summary>
        /// 求签业务上下文数据，与当前支付记录一一对应的业务属性
        /// </summary>
        [XmlElement("biz_context")]
        public DivinationBizContextDetail BizContext { get; set; }

        /// <summary>
        /// 业务回执字段，服务不做处理，透传回给调用方做相关业务逻辑处理。
        /// </summary>
        [XmlElement("biz_receipt")]
        public string BizReceipt { get; set; }

        /// <summary>
        /// 一体机设备的ID，全局唯一
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 外部客户ID，由调用方提供，标明当前在当前场景下的唯一用户ID
        /// </summary>
        [XmlElement("external_client_id")]
        public string ExternalClientId { get; set; }

        /// <summary>
        /// 外部用户名称
        /// </summary>
        [XmlElement("external_client_name")]
        public string ExternalClientName { get; set; }

        /// <summary>
        /// 捐献金额，单位是元，保留两位小数
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付日期
        /// </summary>
        [XmlElement("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 支付场景：TEMPLE_DIVINATION 求签
        /// </summary>
        [XmlElement("pay_scene")]
        public string PayScene { get; set; }

        /// <summary>
        /// 调用方传入数据的唯一请求Id,用来幂等处理
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
