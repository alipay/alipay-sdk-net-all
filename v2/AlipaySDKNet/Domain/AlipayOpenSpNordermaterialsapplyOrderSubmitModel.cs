using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyOrderSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyOrderSubmitModel : AopObject
    {
        /// <summary>
        /// 此前接口蚂蚁侧返回的创建申请单ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 组合单号，基于此单号创建的所有申请单都在一个组合单下，可以统一提交。 与apply_id参数必传一个
        /// </summary>
        [XmlElement("combined_order_no")]
        public string CombinedOrderNo { get; set; }
    }
}
