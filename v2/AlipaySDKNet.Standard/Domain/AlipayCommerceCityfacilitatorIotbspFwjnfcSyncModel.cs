using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotbspFwjnfcSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorIotbspFwjnfcSyncModel : AopObject
    {
        /// <summary>
        /// 贴一贴后需要跳转的小程序appId
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// nfc设备BizTid，为NFC模块生成的设备唯一ID，非必填属性
        /// </summary>
        [XmlElement("nfc_biz_tid")]
        public string NfcBizTid { get; set; }

        /// <summary>
        /// nfc设备Sn编码
        /// </summary>
        [XmlElement("nfc_sn")]
        public string NfcSn { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 小程序跳转地址参数，非必填，无参数可不配置
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 调用方的商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 小程序跳转时，需要额外传递的页面参数
        /// </summary>
        [XmlElement("query_params")]
        public string QueryParams { get; set; }

        /// <summary>
        /// 贴一贴小程序跳转的页面地址
        /// </summary>
        [XmlElement("route_page")]
        public string RoutePage { get; set; }

        /// <summary>
        /// 上位机biztid，，为上位机设备唯一ID
        /// </summary>
        [XmlElement("upper_biz_tid")]
        public string UpperBizTid { get; set; }

        /// <summary>
        /// 上位机sn，为商户设备的设备唯一ID
        /// </summary>
        [XmlElement("upper_sn")]
        public string UpperSn { get; set; }

        /// <summary>
        /// isv小程序跳转url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
