using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationTradedataBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationTradedataBatchqueryModel : AopObject
    {
        /// <summary>
        /// 日期类型，DAY:日，MONTH:月
        /// </summary>
        [XmlElement("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 商业关系id，如：商圈mallid
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
        /// 查询页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询大小，建议填10，限制最大为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 开始日期，如果data_type为DAY时，start_date格式为yyyyMMdd，如果data_type为MONTH时，start_date格式为yyyyMM
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 目标类型，MALL:商圈，SHOP:门店
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
