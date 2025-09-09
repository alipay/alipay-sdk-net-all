using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneAccountSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSceneAccountSyncModel : AopObject
    {
        /// <summary>
        /// 芝麻企业信用赋予的唯一业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 开通场景账户失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 开通场景账户结果
        /// </summary>
        [XmlElement("open_status")]
        public string OpenStatus { get; set; }

        /// <summary>
        /// 同步平台账户在平台的相关操作
        /// </summary>
        [XmlArray("sync_content")]
        [XmlArrayItem("string")]
        public List<string> SyncContent { get; set; }
    }
}
