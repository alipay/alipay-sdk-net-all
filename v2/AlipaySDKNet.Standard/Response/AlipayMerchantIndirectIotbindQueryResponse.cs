using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectIotbindQueryResponse.
    /// </summary>
    public class AlipayMerchantIndirectIotbindQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备绑定状态：BIND代表绑定，UNBIND代表未绑定
        /// </summary>
        [XmlElement("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 设备最新一次绑定时间（格式为yyyy-MM-dd HH:mm:ss）。如果设备没有绑定过或者已经解绑，该字段为空
        /// </summary>
        [XmlElement("bind_time")]
        public string BindTime { get; set; }

        /// <summary>
        /// 不同物联网平台接入渠道不同值，支付宝物联网平台传设备SN号，阿里云物联网平台传设备deviceName
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 碰音箱在商户绑定时上传的二维码地址。
        /// </summary>
        [XmlElement("encode_url")]
        public string EncodeUrl { get; set; }

        /// <summary>
        /// 最近一次预投的非支付宝交易到账播报语料ID。
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 设备绑定的商户在支付宝体系内的唯一id,一般以2088开头。设备处于已绑定状态时会返回对应绑定商户id。如果设备没有绑定过或者已经解绑，该字段为空
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 最近一次预投的非支付宝交易到账播报语料内容。
        /// </summary>
        [XmlElement("speech_content")]
        public string SpeechContent { get; set; }

        /// <summary>
        /// 不同物联网平台接入渠道不同值，支付宝物联网平台传设备sourceId号，阿里云物联网平台传设备productKey
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
