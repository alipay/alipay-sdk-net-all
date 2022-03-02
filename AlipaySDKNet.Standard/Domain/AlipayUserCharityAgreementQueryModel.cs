using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCharityAgreementQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCharityAgreementQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景，由爱心捐赠系统配置及分配
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 产品码，由爱心捐赠系统配置及分配
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 需要签约协议的用户PID
        /// </summary>
        [XmlElement("withhold_pid")]
        public string WithholdPid { get; set; }
    }
}
