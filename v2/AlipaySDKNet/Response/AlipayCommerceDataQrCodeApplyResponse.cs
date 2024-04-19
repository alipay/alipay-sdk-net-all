using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataQrCodeApplyResponse.
    /// </summary>
    public class AlipayCommerceDataQrCodeApplyResponse : AopResponse
    {
        /// <summary>
        /// 对应入参的biz_type
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 码图片url（png格式，背景透明）
        /// </summary>
        [XmlElement("dynamic_img_url")]
        public string DynamicImgUrl { get; set; }

        /// <summary>
        /// 码图片url（白色背景）
        /// </summary>
        [XmlElement("dynamic_img_url_and_trans")]
        public string DynamicImgUrlAndTrans { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 对应入参isv_pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 对应入参的outer_biz_id
        /// </summary>
        [XmlElement("outer_biz_id")]
        public string OuterBizId { get; set; }

        /// <summary>
        /// 对应入参的page_url
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 二维码链接
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 对应入参的shop_id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
