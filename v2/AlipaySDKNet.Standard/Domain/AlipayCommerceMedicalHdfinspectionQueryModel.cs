using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfinspectionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfinspectionQueryModel : AopObject
    {
        /// <summary>
        /// hdf的authCode
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 双方定义
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }
    }
}
