using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpAcceptanceInitializeResponse : AopResponse
    {
        /// <summary>
        /// 芝麻企业信用数据访问令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户接入企业信用受理台服务H5页面地址 （根据平台的具体应用场景决策返回，目前是实力标产品并且入参指定企业时）
        /// </summary>
        [XmlElement("access_url")]
        public string AccessUrl { get; set; }

        /// <summary>
        /// 一次受理的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成（当商户传入时返回）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
