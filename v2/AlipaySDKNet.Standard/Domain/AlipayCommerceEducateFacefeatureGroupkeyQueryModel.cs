using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureGroupkeyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacefeatureGroupkeyQueryModel : AopObject
    {
        /// <summary>
        /// 人脸特征场景码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 服务商英文简称（SCHOOL_PAYMENT场景不需要提供）
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
