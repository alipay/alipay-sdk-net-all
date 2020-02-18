using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarCarmodelQueryResponse.
    /// </summary>
    public class AlipayEcoMycarCarmodelQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝车型库品牌背景图片链接地址
        /// </summary>
        [XmlElement("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 支付宝车型库品牌编号（系统唯一）
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 支付宝车型库品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 支付宝车型库车型排量
        /// </summary>
        [XmlElement("cc")]
        public string Cc { get; set; }

        /// <summary>
        /// 支付宝车型库厂商编号（系统唯一）
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 支付宝车型库厂商名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 支付宝车型库车型发动机号
        /// </summary>
        [XmlElement("engine")]
        public string Engine { get; set; }

        /// <summary>
        /// 支付宝车型库品牌logo图片链接地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 支付宝车型库车型编号（系统唯一）
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 支付宝车型库车型名称
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 支付宝车型库车型生产年限
        /// </summary>
        [XmlElement("prod_year")]
        public string ProdYear { get; set; }

        /// <summary>
        /// 支付宝车型库车系编号（系统唯一）
        /// </summary>
        [XmlElement("serie_id")]
        public string SerieId { get; set; }

        /// <summary>
        /// 支付宝车型库车系名称
        /// </summary>
        [XmlElement("serie_name")]
        public string SerieName { get; set; }

        /// <summary>
        /// 支付宝车型库车系图片连接地址
        /// </summary>
        [XmlElement("serie_photo")]
        public string SeriePhoto { get; set; }

        /// <summary>
        /// 支付宝车型库车型年款
        /// </summary>
        [XmlElement("style")]
        public string Style { get; set; }
    }
}
