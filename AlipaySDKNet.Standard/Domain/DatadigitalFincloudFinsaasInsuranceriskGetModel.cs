using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceriskGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasInsuranceriskGetModel : AopObject
    {
        /// <summary>
        /// 身份证MD5或者hash码
        /// </summary>
        [XmlElement("cert_no_code")]
        public string CertNoCode { get; set; }

        /// <summary>
        /// 数据类型 1=预测值 2=黑名单
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("telephone_num")]
        public string TelephoneNum { get; set; }
    }
}
