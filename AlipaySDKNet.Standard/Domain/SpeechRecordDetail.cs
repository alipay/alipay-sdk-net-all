using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpeechRecordDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SpeechRecordDetail : AopObject
    {
        /// <summary>
        /// 播报关联的支付宝运营计划id
        /// </summary>
        [XmlElement("alipay_plan_id")]
        public string AlipayPlanId { get; set; }

        /// <summary>
        /// 设备在线地址必传
        /// </summary>
        [XmlElement("device_address")]
        public string DeviceAddress { get; set; }

        /// <summary>
        /// 设备所在城市中文名称
        /// </summary>
        [XmlElement("device_city")]
        public string DeviceCity { get; set; }

        /// <summary>
        /// 设备所在区中文名称
        /// </summary>
        [XmlElement("device_district")]
        public string DeviceDistrict { get; set; }

        /// <summary>
        /// 设备ip地址需要传入公网有效ip
        /// </summary>
        [XmlElement("device_ip")]
        public string DeviceIp { get; set; }

        /// <summary>
        /// 设备所在地址纬度
        /// </summary>
        [XmlElement("device_latitude")]
        public string DeviceLatitude { get; set; }

        /// <summary>
        /// 设备所在地址经度
        /// </summary>
        [XmlElement("device_longitude")]
        public string DeviceLongitude { get; set; }

        /// <summary>
        /// 最后一次开机时间，毫秒时间戳
        /// </summary>
        [XmlElement("device_online_time")]
        public string DeviceOnlineTime { get; set; }

        /// <summary>
        /// 设备操作系统版本
        /// </summary>
        [XmlElement("device_os_version")]
        public string DeviceOsVersion { get; set; }

        /// <summary>
        /// 设备所在省中文名称
        /// </summary>
        [XmlElement("device_province")]
        public string DeviceProvince { get; set; }

        /// <summary>
        /// 设备软件SDK版本号
        /// </summary>
        [XmlElement("device_sdk_version")]
        public string DeviceSdkVersion { get; set; }

        /// <summary>
        /// 设备SN号
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备音量值，根据设备情况传入
        /// </summary>
        [XmlElement("device_sound")]
        public string DeviceSound { get; set; }

        /// <summary>
        /// 设备 supplier_id,用于区分设备类型
        /// </summary>
        [XmlElement("device_supplier_id")]
        public string DeviceSupplierId { get; set; }

        /// <summary>
        /// 外部服务商运营计划结束时间，毫秒级时间戳
        /// </summary>
        [XmlElement("out_plan_end_time")]
        public string OutPlanEndTime { get; set; }

        /// <summary>
        /// 外部服务商语音播报平台的运营计划id
        /// </summary>
        [XmlElement("out_plan_id")]
        public string OutPlanId { get; set; }

        /// <summary>
        /// 外部服务商运营计划开始时间，毫秒级时间戳
        /// </summary>
        [XmlElement("out_plan_start_time")]
        public string OutPlanStartTime { get; set; }

        /// <summary>
        /// 设备关联的间连商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 语音播报内容，字符串文本形式
        /// </summary>
        [XmlElement("speech_content")]
        public string SpeechContent { get; set; }

        /// <summary>
        /// 区分播报记录的唯一标识
        /// </summary>
        [XmlElement("speech_id")]
        public string SpeechId { get; set; }

        /// <summary>
        /// 语音播报结果，如果系统暂不支持传UNKNOWN
        /// </summary>
        [XmlElement("speech_result")]
        public string SpeechResult { get; set; }

        /// <summary>
        /// 语音播报结果详情，当播报结果为FAIL的情况下必须传入具体的原因
        /// </summary>
        [XmlElement("speech_result_msg")]
        public string SpeechResultMsg { get; set; }

        /// <summary>
        /// 播报场景类型，支付到账类的传TRADE，营销类的传PROMOTION
        /// </summary>
        [XmlElement("speech_scene")]
        public string SpeechScene { get; set; }

        /// <summary>
        /// 语音播报时间，毫秒级时间戳传入。只接收T-1的播报数据，例如11月22号上传的数据的播报时间不能早于11月21号
        /// </summary>
        [XmlElement("speech_time")]
        public string SpeechTime { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 交易播报关联的支付宝交易单号。当交易渠道为支付宝的时候需要传入，其他情况传空。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
