using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceLabelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAcceptanceLabelQueryModel : AopObject
    {
        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 受理台业务场景类别，由芝麻企业信用方分发提供，配置有误会返回参数错误
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 是否用于前端展示标识（true标识用于展示，false标识不用于展示，不传代表false不用于展示）
        /// </summary>
        [XmlElement("show_flag")]
        public bool ShowFlag { get; set; }
    }
}
