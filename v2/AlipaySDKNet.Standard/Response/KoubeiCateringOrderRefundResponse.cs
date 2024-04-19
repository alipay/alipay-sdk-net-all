using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringOrderRefundResponse.
    /// </summary>
    public class KoubeiCateringOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 口碑端订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退款明细列表
        /// </summary>
        [XmlArray("refund_description_list")]
        [XmlArrayItem("refund_description_d_t_o")]
        public List<RefundDescriptionDTO> RefundDescriptionList { get; set; }

        /// <summary>
        /// 口碑退款单id
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 是否需要重试，true-需要，false-不需要
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
