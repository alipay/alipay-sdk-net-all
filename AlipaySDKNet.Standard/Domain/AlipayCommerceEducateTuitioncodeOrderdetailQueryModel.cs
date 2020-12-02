using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrderdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodeOrderdetailQueryModel : AopObject
    {
        /// <summary>
        /// 是否查询打款计划列表
        /// </summary>
        [XmlElement("include_plans")]
        public bool IncludePlans { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 场景，固定"XFM"
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
