using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPromoRecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationPromoRecordQueryModel : AopObject
    {
        /// <summary>
        /// 活动编码，固定值
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 特殊场景使用，无需求可不传
        /// </summary>
        [XmlElement("query_data")]
        public string QueryData { get; set; }

        /// <summary>
        /// 在餐饮场景下，支付宝用户的报名记录为主报名记录，名下的门店报名记录为子报名记录。配合subject_type/subject_id参数，可用于查询某个支付宝账号名下报名的门店；
        /// </summary>
        [XmlElement("query_sub_record")]
        public bool QuerySubRecord { get; set; }

        /// <summary>
        /// 活动期次ID
        /// </summary>
        [XmlElement("round_id")]
        public string RoundId { get; set; }

        /// <summary>
        /// 主体ID，支持按照报名接口返回的ID传值，也可以传对应的支付宝账号
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 主体类型，支持按照报名接口返回的类型，也可以传对应的支付宝账号类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
