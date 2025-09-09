using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantNpromoIndirectQueryResponse.
    /// </summary>
    public class AlipayMerchantNpromoIndirectQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议描述文案
        /// </summary>
        [XmlElement("pop_agreement_desc")]
        public string PopAgreementDesc { get; set; }

        /// <summary>
        /// 协议列表
        /// </summary>
        [XmlArray("pop_agreement_list")]
        [XmlArrayItem("promo_agreement_info")]
        public List<PromoAgreementInfo> PopAgreementList { get; set; }

        /// <summary>
        /// 弹窗中部图片URL
        /// </summary>
        [XmlElement("pop_body_img")]
        public string PopBodyImg { get; set; }

        /// <summary>
        /// 品牌联名图片URL
        /// </summary>
        [XmlElement("pop_brand_img")]
        public string PopBrandImg { get; set; }

        /// <summary>
        /// 弹窗按钮图片URL
        /// </summary>
        [XmlElement("pop_btn_img")]
        public string PopBtnImg { get; set; }

        /// <summary>
        /// 弹窗头部图片URL
        /// </summary>
        [XmlElement("pop_header_img")]
        public string PopHeaderImg { get; set; }

        /// <summary>
        /// 页面跳转链接
        /// </summary>
        [XmlElement("pop_url")]
        public string PopUrl { get; set; }

        /// <summary>
        /// 当前内容的业务场景编码 设备申请场景：DVC_APPLY 营销活动场景：PROMO_ACTIVITY
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 本次请求是否展示入口
        /// </summary>
        [XmlElement("show")]
        public bool Show { get; set; }
    }
}
