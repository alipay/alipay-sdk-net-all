using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifecreationTransportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifecreationTransportQueryModel : AopObject
    {
        /// <summary>
        /// 查询业务日期，仅支持 yyyy-MM-dd 格式
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 创作搬运合作的供应商结构编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }
    }
}
