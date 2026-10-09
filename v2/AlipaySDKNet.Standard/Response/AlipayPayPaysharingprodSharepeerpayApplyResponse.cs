using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayPaysharingprodSharepeerpayApplyResponse.
    /// </summary>
    public class AlipayPayPaysharingprodSharepeerpayApplyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝好友分享代付链接
        /// </summary>
        [XmlElement("friend_share_page_url")]
        public string FriendSharePageUrl { get; set; }

        /// <summary>
        /// 代付单号
        /// </summary>
        [XmlElement("peerpay_order_no")]
        public string PeerpayOrderNo { get; set; }

        /// <summary>
        /// 分享代付二维码码值
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 分享代付二维码图片
        /// </summary>
        [XmlElement("qrcode_image")]
        public string QrcodeImage { get; set; }

        /// <summary>
        /// 分享代付吱口令
        /// </summary>
        [XmlElement("ztoken")]
        public string Ztoken { get; set; }
    }
}
