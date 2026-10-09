using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseBsnQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseBsnQueryResponse : AopResponse
    {
        /// <summary>
        /// 已申请备案服务码列表
        /// </summary>
        [XmlArray("bsns")]
        [XmlArrayItem("aliyun_b_s_n")]
        public List<AliyunBSN> Bsns { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
