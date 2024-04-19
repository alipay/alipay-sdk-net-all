using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsCompanyIstd Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsCompanyIstd : AopObject
    {
        /// <summary>
        /// 即时配送公司编码，由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 即时配送公司服务代码列表
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("service_code_istd")]
        public List<ServiceCodeIstd> ServiceCodes { get; set; }
    }
}
