using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduTradeExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EduTradeExtInfo : AopObject
    {
        /// <summary>
        /// 课程描述信息
        /// </summary>
        [XmlElement("course_desc")]
        public string CourseDesc { get; set; }

        /// <summary>
        /// 课程图片地址
        /// </summary>
        [XmlElement("course_img_url")]
        public string CourseImgUrl { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("course_name")]
        public string CourseName { get; set; }

        /// <summary>
        /// 课程标签
        /// </summary>
        [XmlElement("course_tag")]
        public string CourseTag { get; set; }

        /// <summary>
        /// 课程原价，单位元，两位小数
        /// </summary>
        [XmlElement("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 外部课程编号
        /// </summary>
        [XmlElement("out_course_id")]
        public string OutCourseId { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 课程单价，单位元，两位小数
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 门店图片地址
        /// </summary>
        [XmlElement("shop_img_url")]
        public string ShopImgUrl { get; set; }

        /// <summary>
        /// 店铺别名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店可跳转地址
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }
    }
}
