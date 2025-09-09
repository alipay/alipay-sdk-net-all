using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EbikeChargeQrcodeParam Data Structure.
    /// </summary>
    [Serializable]
    public class EbikeChargeQrcodeParam : AopObject
    {
        /// <summary>
        /// 业务流水号，标识一笔生码数据，用于幂等判断，返回值中原样返回
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 标识来源系统
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 对应的二维码描述
        /// </summary>
        [XmlElement("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 码值拼接参数，最多5对，用来拼接到码值，内容按照格式为参数名=参数值&参数名=参数值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 小程序启动参数，内容按照格式为参数名=参数值&参数名=参数值
        /// </summary>
        [XmlElement("query_param")]
        public string QueryParam { get; set; }

        /// <summary>
        /// 合成后图片的大小规格，有s、m、l三档可选，默认s，单位cm
        /// </summary>
        [XmlElement("size")]
        public string Size { get; set; }

        /// <summary>
        /// page/component/component-pages/view/view为小程序中能访问到的页面路径
        /// </summary>
        [XmlElement("url_param")]
        public string UrlParam { get; set; }
    }
}
