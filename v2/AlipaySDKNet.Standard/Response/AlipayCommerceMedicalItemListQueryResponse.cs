using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalItemListQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalItemListQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlArray("item_info_list")]
        [XmlArrayItem("item_info_detail")]
        public List<ItemInfoDetail> ItemInfoList { get; set; }

        /// <summary>
        /// 页面页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小,单位条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店商品总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
