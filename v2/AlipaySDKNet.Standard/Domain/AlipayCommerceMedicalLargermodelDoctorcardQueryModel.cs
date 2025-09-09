using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelDoctorcardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalLargermodelDoctorcardQueryModel : AopObject
    {
        /// <summary>
        /// 科室id，在卡片extInfo中返回给扁鹊，带入到这个接口即可
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 医院id即orgId
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }
    }
}
