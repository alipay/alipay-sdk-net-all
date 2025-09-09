using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupPromotechannelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupPromotechannelBatchqueryModel : AopObject
    {
        /// <summary>
        /// 群组id，表里唯一键，创建群组自动生成，编辑群组必填
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 分页查询的页码值
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询页大小参数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 父渠道节点id，如果是查询一级渠道，不需要传父节点id
        /// </summary>
        [XmlElement("parent_id")]
        public long ParentId { get; set; }
    }
}
