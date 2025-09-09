using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcCertifiedtripQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcCertifiedtripQueryResponse : AopResponse
    {
        /// <summary>
        /// SUCCESS：订单申请成功； FAIL:申请失败
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 其他业务异常信息描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 行程单据列表
        /// </summary>
        [XmlArray("etc_auth_trip")]
        [XmlArrayItem("etc_auth_trip")]
        public List<EtcAuthTrip> EtcAuthTrip { get; set; }

        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
