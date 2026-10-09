using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyOrderQueryResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 申请单的状态描述
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 状态编码
        /// </summary>
        [XmlElement("apply_status_code")]
        public string ApplyStatusCode { get; set; }

        /// <summary>
        /// 该申请单下物料数量 ，单位个
        /// </summary>
        [XmlElement("materials_num")]
        public long MaterialsNum { get; set; }

        /// <summary>
        /// 审批不通过的原因
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 申请单下的门店订单数量
        /// </summary>
        [XmlElement("shop_num")]
        public long ShopNum { get; set; }
    }
}
