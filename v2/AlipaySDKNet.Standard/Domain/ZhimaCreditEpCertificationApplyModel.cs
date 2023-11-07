using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCertificationApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCertificationApplyModel : AopObject
    {
        /// <summary>
        /// 一次认证的唯一标识,在商户调用认证初始化接口的时候获取
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户指定的设备类型，不填则前端根据实际设备类型自动路由
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }
    }
}
