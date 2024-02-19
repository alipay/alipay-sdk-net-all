using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceAccessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAcceptanceAccessQueryModel : AopObject
    {
        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 受理台业务场景类别，由蚂蚁企业信用方分发提供，配置有误会返回参数错误
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
