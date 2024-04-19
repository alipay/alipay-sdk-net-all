using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityListCreateResponse.
    /// </summary>
    public class AlipayOpenAppItempromoactivityListCreateResponse : AopResponse
    {
        /// <summary>
        /// 失败的商品
        /// </summary>
        [XmlArray("failed_item_list")]
        [XmlArrayItem("item_promo_activity_fail_v_o")]
        public List<ItemPromoActivityFailVO> FailedItemList { get; set; }

        /// <summary>
        /// 成功的数量
        /// </summary>
        [XmlElement("success_num")]
        public long SuccessNum { get; set; }

        /// <summary>
        /// 提交的所有数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
