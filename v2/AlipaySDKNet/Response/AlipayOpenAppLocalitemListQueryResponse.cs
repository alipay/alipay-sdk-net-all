using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppLocalitemListQueryResponse.
    /// </summary>
    public class AlipayOpenAppLocalitemListQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("local_item_v_o")]
        public List<LocalItemVO> Items { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 符合条件的商品总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
