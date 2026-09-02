using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFlowPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionFlowPreconsultModel : AopObject
    {
        /// <summary>
        /// 触达渠道
        /// </summary>
        [XmlElement("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 支付宝的userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 加密后手机号
        /// </summary>
        [XmlElement("encrypted_mobile")]
        public string EncryptedMobile { get; set; }

        /// <summary>
        /// 一级投流平台
        /// </summary>
        [XmlElement("first_channel")]
        public string FirstChannel { get; set; }

        /// <summary>
        /// 固定点位
        /// </summary>
        [XmlElement("fixed_position_code")]
        public string FixedPositionCode { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订购页URL
        /// </summary>
        [XmlElement("proxy_order_url")]
        public string ProxyOrderUrl { get; set; }

        /// <summary>
        /// 报备素材编号
        /// </summary>
        [XmlElement("report_materials_no")]
        public string ReportMaterialsNo { get; set; }

        /// <summary>
        /// 请求号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 二级投流平台
        /// </summary>
        [XmlElement("second_channel")]
        public string SecondChannel { get; set; }

        /// <summary>
        /// 目标账号
        /// </summary>
        [XmlElement("target_account")]
        public string TargetAccount { get; set; }
    }
}
