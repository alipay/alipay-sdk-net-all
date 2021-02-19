using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServiceCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmServiceCloseModel : AopObject
    {
        /// <summary>
        /// 服务代码。通过<a href="https://opendocs.alipay.com/apis/01dmgh">alipay.iservice.ccm.service.initialize</a>(isv服务初始化接口) 获取。
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
