using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAcceptanceInitializeModel : AopObject
    {
        /// <summary>
        /// 平台访问指定的设备类型，不填则前端根据用户实际设备类型自动加载
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 使用蚂蚁企业信用相关服务后，回跳到该商户指定的地址
        /// </summary>
        [XmlElement("merchant_return_url")]
        public string MerchantReturnUrl { get; set; }

        /// <summary>
        /// 商户唯一业务流水号，由大小写字母和数字构成。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 受理场景码，由蚂蚁企业信用方分发提供，配置有误会返回参数错误
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
