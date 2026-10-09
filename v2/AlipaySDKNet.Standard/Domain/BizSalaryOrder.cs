using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizSalaryOrder Data Structure.
    /// </summary>
    [Serializable]
    public class BizSalaryOrder : AopObject
    {
        /// <summary>
        /// 发薪申请关联的业务单据对应的单据号，请求方自行制定。
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 雇主名称
        /// </summary>
        [XmlElement("employer_name")]
        public string EmployerName { get; set; }
    }
}
