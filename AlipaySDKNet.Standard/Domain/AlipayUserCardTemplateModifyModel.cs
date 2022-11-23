using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCardTemplateModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCardTemplateModifyModel : AopObject
    {
        /// <summary>
        /// background_url：在支付宝卡包展示的背景图片地址，通过alipay.offline.material.image.upload接口上传图片资源获取(https://opendocs.alipay.com/open/02qth8)
        /// </summary>
        [XmlElement("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// banner_image_url：在支付宝卡包展示的banner图片地址，url通过alipay.offline.material.image.upload接口上传图片资源获取(https://opendocs.alipay.com/open/02qth8)
        /// </summary>
        [XmlElement("banner_image_url")]
        public string BannerImageUrl { get; set; }

        /// <summary>
        /// banner_url：用户在支付宝卡包，店家卡banner后的跳转服务地址
        /// </summary>
        [XmlElement("banner_url")]
        public string BannerUrl { get; set; }

        /// <summary>
        /// code_type:在支付宝卡包中展示的码类型
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// date_type：卡的有效期类型，如果永久有效则填写PERMANENT，如果一段时间内有效则填写PERIOD
        /// </summary>
        [XmlElement("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// description：可填写卡的使用规则、注意事项等
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// logo_url：在支付宝卡包展示的logo地址，通过alipay.offline.material.image.upload接口上传图片资源获取(https://opendocs.alipay.com/open/02qth8)
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// need_balance：卡是否有余额属性
        /// </summary>
        [XmlElement("need_balance")]
        public bool NeedBalance { get; set; }

        /// <summary>
        /// need_level：卡是否有等级属性
        /// </summary>
        [XmlElement("need_level")]
        public bool NeedLevel { get; set; }

        /// <summary>
        /// need_point：卡是否有积分属性
        /// </summary>
        [XmlElement("need_point")]
        public bool NeedPoint { get; set; }

        /// <summary>
        /// point_display_name：积分属性在卡包里展示的名称，默认值为积分
        /// </summary>
        [XmlElement("point_display_name")]
        public string PointDisplayName { get; set; }

        /// <summary>
        /// private_card_page_url：用户在支付宝卡包，点击会员卡cell，跳转的私域卡详情页地址
        /// </summary>
        [XmlElement("private_card_page_url")]
        public string PrivateCardPageUrl { get; set; }

        /// <summary>
        /// quick_services：卡的快捷服务，快捷服务数量限制为[1,3]
        /// </summary>
        [XmlArray("quick_services")]
        [XmlArrayItem("card_quick_service_d_t_o")]
        public List<CardQuickServiceDTO> QuickServices { get; set; }

        /// <summary>
        /// service_phone：卡服务电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// sub_title:在支付宝卡包中展示的卡副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// template_id：卡模版id，为alipay.user.card.template.create接口返回的模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// title:在支付宝卡包中展示的卡名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
