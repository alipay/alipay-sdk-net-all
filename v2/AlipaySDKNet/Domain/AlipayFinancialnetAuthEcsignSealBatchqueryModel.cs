using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSealBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignSealBatchqueryModel : AopObject
    {
        /// <summary>
        /// 页，默认1，必须要大于0。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，默认200。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 印章ID，如果有则为唯一值，用于印章更新场景，在创建完和更新完均会返回该值。
        /// </summary>
        [XmlElement("seal_id")]
        public string SealId { get; set; }

        /// <summary>
        /// 印章名称，无需唯一，用于印章命名，来源是用户自定义，模糊查询。
        /// </summary>
        [XmlElement("seal_name")]
        public string SealName { get; set; }
    }
}
