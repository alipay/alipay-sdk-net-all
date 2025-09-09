using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitRecordQueryComponent Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitRecordQueryComponent : AopObject
    {
        /// <summary>
        /// 查询结束时间
        /// </summary>
        [XmlElement("end_query_date")]
        public string EndQueryDate { get; set; }

        /// <summary>
        /// 玩法模版编码
        /// </summary>
        [XmlElement("ldp_code")]
        public string LdpCode { get; set; }

        /// <summary>
        /// 分页页数，默认为1
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页大小，默认为10条记录
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 权益来源标识，非固定值，由业务运营定义
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [XmlElement("start_query_date")]
        public string StartQueryDate { get; set; }
    }
}
