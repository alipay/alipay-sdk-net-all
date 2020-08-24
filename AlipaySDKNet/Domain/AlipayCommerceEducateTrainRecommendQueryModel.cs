using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainRecommendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTrainRecommendQueryModel : AopObject
    {
        /// <summary>
        /// 业务定制参数
        /// </summary>
        [XmlElement("biz_ext_info")]
        public EduTrainExtInfo BizExtInfo { get; set; }

        /// <summary>
        /// 学段编码
        /// </summary>
        [XmlElement("first_cate")]
        public string FirstCate { get; set; }

        /// <summary>
        /// 页数（默认1）
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 页大小(默认20，上限50)
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 产品码 教育缴费：EDU_PAY 支课堂教培：EDU_TRAIN
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 算法定制参数
        /// </summary>
        [XmlElement("rec_ext_info")]
        public EduTrainExtInfo RecExtInfo { get; set; }

        /// <summary>
        /// 场景码 支课堂：education_course_rec
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 类目编码
        /// </summary>
        [XmlElement("secend_cate")]
        public string SecendCate { get; set; }

        /// <summary>
        /// 子产品码 教育缴费-支付成功页：PAY_SUCCESS 教育缴费-账单详情页：BILL_DETAIL 支课堂-教培课程：TRAIN_COURSE
        /// </summary>
        [XmlElement("sub_product_code")]
        public string SubProductCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
