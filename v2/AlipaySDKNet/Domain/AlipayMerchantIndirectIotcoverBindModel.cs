using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectIotcoverBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectIotcoverBindModel : AopObject
    {
        /// <summary>
        /// 声网入网申请单编号编号是由服务商和支付宝BD录入IoT设备接入协议后生成的，用于后续政策返佣、播报跟踪等重要场景。需要联系支付宝的业务经理获取。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 合约机和lite接入模式传设备SN号，千里传音接入模式传设备deviceName
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 碰音箱在商户绑定时上传的二维码地址,部分supplier_id该字段必传。
        /// </summary>
        [XmlElement("encode_url")]
        public string EncodeUrl { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商家的屏幕收款二维码链接
        /// </summary>
        [XmlElement("screen_pay_qr_link")]
        public string ScreenPayQrLink { get; set; }

        /// <summary>
        /// 间连商户在支付宝体系内的唯一id,一般以2088开头。
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 播报内容配置，如不传时将使用默认播报内容。仅支持SDK模式音响类型设备，其他类型设备请勿传该字段。
        /// </summary>
        [XmlElement("speech_content")]
        public IotSpeechContentConfig SpeechContent { get; set; }

        /// <summary>
        /// 合约机模式必传设备sourceId号，千里传音模式必传设备的productKey，lite模式必传分配给服务商的设备型号编码
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
