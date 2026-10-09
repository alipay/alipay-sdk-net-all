using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySalaryAccountlogQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySalaryAccountlogQueryModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 子户卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 结束时间，格式yyyy-MM-dd HH:mm:ss 结束时间和起始时间，时间差不能超过90天 左闭右开
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 代发商户的商户号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 页数，大于0
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，大于0，小于100
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 对接收付通加签的xml，通过base64Encode编码
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }

        /// <summary>
        /// 起始时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
