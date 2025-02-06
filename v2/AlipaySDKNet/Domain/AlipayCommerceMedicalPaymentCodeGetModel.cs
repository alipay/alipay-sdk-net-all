using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentCodeGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPaymentCodeGetModel : AopObject
    {
        /// <summary>
        /// 用户医保码值
        /// </summary>
        [XmlElement("medical_code")]
        public string MedicalCode { get; set; }

        /// <summary>
        /// 定点医疗机构编码
        /// </summary>
        [XmlElement("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 通过该参数可以重复获取付款码
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
