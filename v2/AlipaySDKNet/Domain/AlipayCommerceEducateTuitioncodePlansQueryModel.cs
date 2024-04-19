using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePlansQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodePlansQueryModel : AopObject
    {
        /// <summary>
        /// 是否包含订单信息
        /// </summary>
        [XmlElement("include_order")]
        public bool IncludeOrder { get; set; }

        /// <summary>
        /// 分页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 场景，固定"XFM"
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 直付通smid,间联商户必传
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 若为空则查询全量  1打款调度中  2打款完成  3退款中  4退款完成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
