using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarCarmodelCreateResponse.
    /// </summary>
    public class AlipayEcoMycarCarmodelCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝车型库品牌编号（新增品牌信息时返回品牌编号）系统唯一
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 支付宝车型库厂商编号（新增厂商信息时返回厂商编号）系统唯一
        /// </summary>
        [XmlElement("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 支付宝车型库车型编号（新增车型信息时返回车型编号）系统唯一
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 支付宝车型库车系编号（新增车系信息时返回车系编号）系统唯一
        /// </summary>
        [XmlElement("serie_id")]
        public string SerieId { get; set; }
    }
}
