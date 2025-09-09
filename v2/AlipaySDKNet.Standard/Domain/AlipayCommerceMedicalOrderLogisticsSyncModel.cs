using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOrderLogisticsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOrderLogisticsSyncModel : AopObject
    {
        /// <summary>
        /// 第三方配送商物流单号，取自商家平台呼叫三方配送骑手的配送订单号
        /// </summary>
        [XmlElement("carrier_order_no")]
        public string CarrierOrderNo { get; set; }

        /// <summary>
        /// 骑手姓名
        /// </summary>
        [XmlElement("courier_name")]
        public string CourierName { get; set; }

        /// <summary>
        /// 骑手手机号码，不支持传入隐私小号
        /// </summary>
        [XmlElement("courier_phone")]
        public string CourierPhone { get; set; }

        /// <summary>
        /// 骑手当前的纬度，使用的是高德坐标系
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 骑手配送状态
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 骑手当前的经度，使用的是高德坐标系
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 配送商类型，值规则：获取商家呼叫的第三方物流配送商，结合当前字段提供的枚举值
        /// </summary>
        [XmlElement("provider_code")]
        public string ProviderCode { get; set; }

        /// <summary>
        /// 配送商电话
        /// </summary>
        [XmlElement("provider_phone")]
        public string ProviderPhone { get; set; }

        /// <summary>
        /// 配送取消/异常的原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 配送取消/异常的原因code 9999 :其他原因（ 商家传入自定义）
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 当前时间，格式：时间戳
        /// </summary>
        [XmlElement("utc")]
        public string Utc { get; set; }
    }
}
