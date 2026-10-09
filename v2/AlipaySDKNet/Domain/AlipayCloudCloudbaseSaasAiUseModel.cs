using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseSaasAiUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseSaasAiUseModel : AopObject
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 模型属性，具体值联系模型服务提供者，身份证需要区分正反面需要传身份证的正面front或者反面side，户口本需要传户主页或者个人页等
        /// </summary>
        [XmlElement("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 待返回的模型字段值，具体联系模型提供者，比如身份证需要返回的是地址则填address，姓名填name
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 带识别的图片属性，需要传公网能访问的图片地址
        /// </summary>
        [XmlElement("param")]
        public string Param { get; set; }

        /// <summary>
        /// 模型服务编码，具体值可查看<a href="https://opendocs.alipay.com/pre-open/09s5qm?pathHash=f2ec2bf8">接口参数说明</a>
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 模型服务uri，具体值可查看<a href="https://opendocs.alipay.com/pre-open/09s5qm?pathHash=f2ec2bf8">接口参数说明</a>
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
