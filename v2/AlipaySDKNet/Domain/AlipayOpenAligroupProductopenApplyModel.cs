using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAligroupProductopenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAligroupProductopenApplyModel : AopObject
    {
        /// <summary>
        /// 申请资质信息
        /// </summary>
        [XmlElement("business_properties")]
        public ApplyBusinessPropertyDTO BusinessProperties { get; set; }

        /// <summary>
        /// 来源渠道标识
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 订单明细行
        /// </summary>
        [XmlArray("order_lines")]
        [XmlArrayItem("apply_order_line_d_t_o")]
        public List<ApplyOrderLineDTO> OrderLines { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
