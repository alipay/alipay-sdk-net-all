using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAuthcodeGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAuthcodeGenerateModel : AopObject
    {
        /// <summary>
        /// 客户系统控制幂等业务单号，由客户系统生成，支付宝侧做接口幂等限制
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 请求接口发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 固定枚举值，美世-MEI_SHI OPPO-OPPO 荣耀-HONOR 小米-XIAOMI
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 客户系统中的用户id,每个用户唯一,由客户系统生成并传入
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 商户APPID
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }

        /// <summary>
        /// 用于描述支付宝用户在开放平台下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户手机号，如有，可传
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 支付宝的用户UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
