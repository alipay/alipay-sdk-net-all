using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainCourseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainCourseCreateModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 课程简介
        /// </summary>
        [XmlElement("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 分类信息(从分类列表接口选取)
        /// </summary>
        [XmlArray("cate_infos")]
        [XmlArrayItem("cate_info")]
        public List<CateInfo> CateInfos { get; set; }

        /// <summary>
        /// 课程详情
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 商家信息
        /// </summary>
        [XmlElement("merchant_info")]
        public ShopMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 上课时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 外部课程id
        /// </summary>
        [XmlElement("out_course_id")]
        public string OutCourseId { get; set; }

        /// <summary>
        /// 课程主图
        /// </summary>
        [XmlElement("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// 场景类型(ONLINE : 线上、OFFLINE : 线下)
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 课程SKU信息
        /// </summary>
        [XmlArray("sku_infos")]
        [XmlArrayItem("course_s_k_u_info")]
        public List<CourseSKUInfo> SkuInfos { get; set; }

        /// <summary>
        /// 来源(XIAOBAO : 校宝)
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tag_infos")]
        [XmlArrayItem("course_tag_info")]
        public List<CourseTagInfo> TagInfos { get; set; }

        /// <summary>
        /// 详情页地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 主视频地址
        /// </summary>
        [XmlElement("video")]
        public string Video { get; set; }
    }
}
