using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardItemCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardItemCreateModel : AopObject
    {
        /// <summary>
        /// 商品描述，不能超过16个字
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 2020-07-01 16:50:05
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("ext_info")]
        public ItemCreateExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 字段已废弃，无需传参
        /// </summary>
        [XmlElement("isv_partner_id")]
        public string IsvPartnerId { get; set; }

        /// <summary>
        /// 商品logo，建议尺寸260*260
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 原价，精确到分
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 外部业务单号，幂等用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 字段已废弃，无需传参
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 现价，精确到分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 2020-07-01 16:50:05
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 次数
        /// </summary>
        [XmlElement("times")]
        public long Times { get; set; }

        /// <summary>
        /// 商品标题，不能超过13个字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
