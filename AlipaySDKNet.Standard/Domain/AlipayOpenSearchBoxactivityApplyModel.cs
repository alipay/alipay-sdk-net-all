using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxactivityApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxactivityApplyModel : AopObject
    {
        /// <summary>
        /// 活动链接，必须为关联的小程序的页面链接（链接以 alipays 开头），可参考<a href="https://opendocs.alipay.com/support/01rb18"> 小程序scheme链接介绍 </a>
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 创建banner活动时，可添加底纹推广词，有机会在首页搜索框内展示，提升banner活动曝光机会
        /// </summary>
        [XmlElement("background_word")]
        public string BackgroundWord { get; set; }

        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }

        /// <summary>
        /// 活动结束时间，开始和结束时间之间不得超过90天
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当material_type="IMAGE"时，为图片id；当material_type="VIDEO"时，为视频id。小程序直达仅支持图片类型。图片id可以通过调用<a href="https://opendocs.alipay.com/mini/03hvl1?ref=api"> 支付宝文件上传接口 </a>上传图片，获取图片id(bizCode：search_box_banner)。<a href="https://opendocs.alipay.com/b/03al6f"> 图片规范 </a>
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// IMAGE-图片/VIDEO-视频
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 商户id，代运营模式下传入。代运营模式，需要服务商已获得商家"运营支付宝小程序"授权。
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 活动开始时间，开始和结束时间之间不得超过90天
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 跳转应用ID
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }

        /// <summary>
        /// 跳转小程序名称
        /// </summary>
        [XmlElement("target_appname")]
        public string TargetAppname { get; set; }

        /// <summary>
        /// 投放目标区域列表
        /// </summary>
        [XmlArray("target_regions")]
        [XmlArrayItem("delivery_target_region")]
        public List<DeliveryTargetRegion> TargetRegions { get; set; }

        /// <summary>
        /// 活动标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 搜索直达活动视频信息
        /// </summary>
        [XmlElement("video_info")]
        public SearchBoxActivityVideoInfo VideoInfo { get; set; }
    }
}
