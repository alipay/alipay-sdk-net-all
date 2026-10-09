using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpIsvSignauthCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpIsvSignauthCreateModel : AopObject
    {
        /// <summary>
        /// 代运营授权场景信息
        /// </summary>
        [XmlArray("isv_auth_scene_infos")]
        [XmlArrayItem("isv_auth_scene_info")]
        public List<IsvAuthSceneInfo> IsvAuthSceneInfos { get; set; }

        /// <summary>
        /// 商户登录账号 支持手机号和邮箱账号；不支持pid
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }

        /// <summary>
        /// 1表示需要，0表示不需要 不传参数默认是需要（1） 是否创建三方应用授权子任务，也就是是否需要给三方应用授权
        /// </summary>
        [XmlElement("need_app_auth")]
        public string NeedAppAuth { get; set; }

        /// <summary>
        /// 签约单号 可通过alipay.open.agent.confirm接口获取签约单号
        /// </summary>
        [XmlElement("sign_order_no")]
        public string SignOrderNo { get; set; }
    }
}
