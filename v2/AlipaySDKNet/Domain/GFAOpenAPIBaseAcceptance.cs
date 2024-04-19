using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIBaseAcceptance Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIBaseAcceptance : AopObject
    {
        /// <summary>
        /// 业财受理单号
        /// </summary>
        [XmlElement("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 业务事件码
        /// </summary>
        [XmlElement("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 端事件码
        /// </summary>
        [XmlElement("cnl_ev_code")]
        public string CnlEvCode { get; set; }

        /// <summary>
        /// 端产品码
        /// </summary>
        [XmlElement("cnl_pd_code")]
        public string CnlPdCode { get; set; }

        /// <summary>
        /// 受理方向
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 业财统一身份Id
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 主体Id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 受理单扩展信息
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 逆向受理关联的业务流水号
        /// </summary>
        [XmlElement("rel_out_business_no")]
        public string RelOutBusinessNo { get; set; }

        /// <summary>
        /// 逆向受理关联的业务流水子单号
        /// </summary>
        [XmlElement("rel_sub_out_business_no")]
        public string RelSubOutBusinessNo { get; set; }

        /// <summary>
        /// 业务唯一标识
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 解决方案id
        /// </summary>
        [XmlElement("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 业务流水子单号
        /// </summary>
        [XmlElement("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 受理来源系统
        /// </summary>
        [XmlElement("system_origin")]
        public string SystemOrigin { get; set; }
    }
}
