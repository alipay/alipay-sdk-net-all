using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthEapAuthorityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrhealthEapAuthorityBatchqueryModel : AopObject
    {
        /// <summary>
        /// 该参数用来标识进入供应商系统的用户标志，是登录供应商应用后解析来的，蚂蚁EAP会将此参数作为用户标志
        /// </summary>
        [XmlElement("biz_emp_id")]
        public string BizEmpId { get; set; }

        /// <summary>
        /// 该参数用来标识用户，是根据用户登录简心后由供应商传入，蚂蚁EAP会根据此作为用户标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 该参数用来标识供应商，是由蚂蚁EAP提供给供应商，蚂蚁EAP侧会根据此参数识别供应商
        /// </summary>
        [XmlElement("data_key")]
        public string DataKey { get; set; }

        /// <summary>
        /// 该参数用来标识用户来源，是供应商不同的场景传入对应的来源，蚂蚁EAP会根据此来判断员工是否在权益范围内
        /// </summary>
        [XmlElement("source")]
        public long Source { get; set; }
    }
}
