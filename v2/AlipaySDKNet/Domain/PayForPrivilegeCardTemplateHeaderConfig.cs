using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayForPrivilegeCardTemplateHeaderConfig Data Structure.
    /// </summary>
    [Serializable]
    public class PayForPrivilegeCardTemplateHeaderConfig : AopObject
    {
        /// <summary>
        /// 卡模板头部logo图片URL，通过https://docs.open.alipay.com/common/105258 接口上传图片获得
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 卡模板头部底图URL，通过https://docs.open.alipay.com/common/105258上传图片获得
        /// </summary>
        [XmlElement("strip")]
        public string Strip { get; set; }

        /// <summary>
        /// 卡模板头部显示名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
