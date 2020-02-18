using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcMediaGetResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcMediaGetResponse : AopResponse
    {
        /// <summary>
        /// 申请单资料列表
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("media_content_list")]
        public List<MediaContentList> ContentList { get; set; }

        /// <summary>
        /// etc申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务申请单id
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
