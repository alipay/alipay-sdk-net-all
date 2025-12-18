using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceUserSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceUserSignQueryModel : AopObject
    {
        /// <summary>
        /// 签约创建时间查询截止时间
        /// </summary>
        [XmlElement("agreement_gmt_create_end")]
        public string AgreementGmtCreateEnd { get; set; }

        /// <summary>
        /// 签约创建时间查询起始时间
        /// </summary>
        [XmlElement("agreement_gmt_create_start")]
        public string AgreementGmtCreateStart { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 每页数据条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
