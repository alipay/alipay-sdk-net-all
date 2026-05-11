using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenNfcorderastTagactivedatalistQueryResponse.
    /// </summary>
    public class AlipayOpenNfcorderastTagactivedatalistQueryResponse : AopResponse
    {
        /// <summary>
        /// 线圈活跃数列表
        /// </summary>
        [XmlElement("data")]
        public NOrderTagActiveDataDTO Data { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("pages")]
        public long Pages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
