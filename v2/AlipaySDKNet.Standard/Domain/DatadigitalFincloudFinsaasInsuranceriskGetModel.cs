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
        /// 身份证MD5或者sha1码
        /// </summary>
        [XmlElement("cert_no_code")]
        public string CertNoCode { get; set; }

        /// <summary>
        /// 数据类型 1=预测值 2=黑名单
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 名称：场景编码 是否唯一：不唯一 应用场景：通过该参数区分不同风控场景  枚举值：黑名单(BlackList)、硬规则(RiskRule)、模型计算(Prediction)、同人(SameUser)
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("telephone_num")]
        public string TelephoneNum { get; set; }
    }
}
