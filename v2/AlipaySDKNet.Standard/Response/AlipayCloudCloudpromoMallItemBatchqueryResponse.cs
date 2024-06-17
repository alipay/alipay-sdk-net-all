using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallItemBatchqueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallItemBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商品详情列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("mpc_l_m_item_v_o")]
        public List<MpcLMItemVO> ItemList { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 圈选商品总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
