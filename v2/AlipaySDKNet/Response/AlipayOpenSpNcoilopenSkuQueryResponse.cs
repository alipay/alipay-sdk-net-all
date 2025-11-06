using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenSkuQueryResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenSkuQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否有桌号
        /// </summary>
        [XmlElement("need_desk_no")]
        public bool NeedDeskNo { get; set; }

        /// <summary>
        /// 是否有点位名称
        /// </summary>
        [XmlElement("need_point_name")]
        public bool NeedPointName { get; set; }

        /// <summary>
        /// 需要二维码
        /// </summary>
        [XmlElement("need_qr_code_link")]
        public bool NeedQrCodeLink { get; set; }

        /// <summary>
        /// sku唯一标识
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 行业解决方案id，solution_id需要由具体业务方提供，联系产品获取
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// ntouch模板code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
