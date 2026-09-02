using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsPetOrgprofileverifyConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsPetOrgprofileverifyConsultModel : AopObject
    {
        /// <summary>
        /// 认证接口返回的校验结果编号
        /// </summary>
        [XmlElement("check_record_no")]
        public string CheckRecordNo { get; set; }
    }
}
