using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectPromotaskBatchqueryModel : AopObject
    {
        /// <summary>
        /// 平台定义的业务场景编码，用以区分不同的业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝侧定义的商户组编号，作为同一商户主体下多个smid的唯一商户编号
        /// </summary>
        [XmlElement("group_mid")]
        public string GroupMid { get; set; }

        /// <summary>
        /// 请求获取的列表条数，最大不超过30条，超过最大限制数接口会报错
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
