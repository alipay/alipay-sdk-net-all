using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityListDeleteResponse.
    /// </summary>
    public class AlipayOpenAppItempromoactivityListDeleteResponse : AopResponse
    {
        /// <summary>
        /// 失败商品列表
        /// </summary>
        [XmlElement("failed_item_list")]
        public ItemPromoActivityFailVO FailedItemList { get; set; }

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
