using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 类目id，按照类目维度圈选商品
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分销店铺id
        /// </summary>
        [XmlElement("purchaser_id")]
        public string PurchaserId { get; set; }
    }
}
