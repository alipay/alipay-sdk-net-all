using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcResouceGetResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcResouceGetResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS：成功；{FAIL}:{失败原因}
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 其他业务异常信息描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 申请单资料列表
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("etc_media_content")]
        public List<EtcMediaContent> ContentList { get; set; }

        /// <summary>
        /// 支付宝侧订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
