using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackagePostpaidCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackagePostpaidCreateModel : AopObject
    {
        /// <summary>
        /// 小程序云应用APPID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境描述
        /// </summary>
        [XmlElement("env_description")]
        public string EnvDescription { get; set; }

        /// <summary>
        /// 环境名称，只能包含数字、小写字母和-，只能以小写字母开头且不超过20个字符
        /// </summary>
        [XmlElement("env_name")]
        public string EnvName { get; set; }

        /// <summary>
        /// 环境区域  - cn-hangzhou
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }
    }
}
