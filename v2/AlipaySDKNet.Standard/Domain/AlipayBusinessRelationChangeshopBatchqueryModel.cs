using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationChangeshopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationChangeshopBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商业关系组织id/业务id，由组织信息创建接口返回或bd分配
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商业关系组织子类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_sub_type")]
        public string GroupSubType { get; set; }

        /// <summary>
        /// 商业关系组织类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商业关系异动门店状态，已处理/未处理，PROCESSED/UNPROCESSED
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }
    }
}
