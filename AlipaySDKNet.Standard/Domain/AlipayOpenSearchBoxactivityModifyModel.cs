using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchBoxactivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchBoxactivityModifyModel : AopObject
    {
        /// <summary>
        /// 活动链接
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 搜索直达活动id
        /// </summary>
        [XmlElement("box_activity_id")]
        public string BoxActivityId { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当material_type="IMAGE"时，为图片id；当material_type="VIDEO"时，为视频id。图片id可以通过调用接口alipay.open.file.upload上传图片，获取图片id。图片规范：https://opendocs.alipay.com/mini/operation/atmospheredesign
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
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 跳转应用ID，当为品牌直达时必传
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
        /// 活动视频信息
        /// </summary>
        [XmlElement("video_info")]
        public SearchBoxActivityVideoInfo VideoInfo { get; set; }
    }
}