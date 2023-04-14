using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BannerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BannerInfo : AopObject
    {
        /// <summary>
        /// banner点击后跳转地址，只能是小程序地址。 字段在操作类型为add的时候为必填
        /// </summary>
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 展示结束时间，可不填，后续下线需要调用op_type为offline来操作下线。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 图片地址，新增操作情况下，图片链接为必填字段
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 展示起始时间，可不填，默认为当前时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
