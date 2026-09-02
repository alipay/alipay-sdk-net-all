using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFloworderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionFloworderCreateModel : AopObject
    {
        /// <summary>
        /// 触达渠道
        /// </summary>
        [XmlElement("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 引流页截图≤500K
        /// </summary>
        [XmlElement("advertorial_img")]
        public string AdvertorialImg { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

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
        /// 机构订单id
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 分销商品id
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
        /// APP名称
        /// </summary>
        [XmlElement("package_name")]
        public string PackageName { get; set; }

        /// <summary>
        /// 应用包名（bundleId）
        /// </summary>
        [XmlElement("package_route")]
        public string PackageRoute { get; set; }

        /// <summary>
        /// 页面标识
        /// </summary>
        [XmlElement("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 订购价格，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 协议id
        /// </summary>
        [XmlElement("protocol_sequence_id")]
        public string ProtocolSequenceId { get; set; }

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
        /// 营销图片≤500K
        /// </summary>
        [XmlElement("sales_img")]
        public string SalesImg { get; set; }

        /// <summary>
        /// sdk凭证
        /// </summary>
        [XmlElement("sdk_voucher")]
        public string SdkVoucher { get; set; }

        /// <summary>
        /// 二级投流平台
        /// </summary>
        [XmlElement("second_channel")]
        public string SecondChannel { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }

        /// <summary>
        /// 目标账号
        /// </summary>
        [XmlElement("target_account")]
        public string TargetAccount { get; set; }

        /// <summary>
        /// 浏览器用户标识
        /// </summary>
        [XmlElement("user_agent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// 二确页图片≤500K
        /// </summary>
        [XmlElement("verify_again_img")]
        public string VerifyAgainImg { get; set; }
    }
}
