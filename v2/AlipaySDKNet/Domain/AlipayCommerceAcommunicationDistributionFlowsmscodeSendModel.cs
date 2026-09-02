using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFlowsmscodeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionFlowsmscodeSendModel : AopObject
    {
        /// <summary>
        /// 触达渠道
        /// </summary>
        [XmlElement("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

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
        /// 分销商订单号
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

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
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

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
        /// 浏览器用户标识
        /// </summary>
        [XmlElement("user_agent")]
        public string UserAgent { get; set; }
    }
}
